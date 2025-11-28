using BLL;
using Entities;
using Entities.Models;
using Mapper;
using QRCoder;
using System.Windows.Forms;
using ZXing;
using ZXing.Windows.Compatibility;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TPIntegrador
{
    public partial class Form1 : Form
    {
        private UsuarioEntity usuarioLogueado;
        private ResidenteBusiness residenteBusiness = new ResidenteBusiness();
        private RepartidorBusiness repartidorBusiness = new RepartidorBusiness();
        private LockerBusiness lockerBusiness = new LockerBusiness();


        public Form1(UsuarioEntity usuario)
        {
            InitializeComponent();
            usuarioLogueado = usuario;

        }
        private UsuarioBusiness usuarioBusiness = new UsuarioBusiness();
        private object pictureBoxQR;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                actualizarDgvResidente();
                actualizarDgvLockers();
                actualizarDgvRepartidor();
                actualizarTxtBox();
                CargarComboBoxLockers();
                CargarComboBoxRepartidor();
                CargarComboBoxResidente();
                GenerarCodigoLocker();

                // 1) Ocultar pestañas según rol
                switch (usuarioLogueado.Rol.ToLower())
                {
                    case "residente":
                        tabControl1.TabPages.Remove(tabPage3);
                        habilitaciones(usuarioLogueado.Id);
                        habilitaciones(usuarioLogueado.Id);
                        break;

                    case "repartidor":
                        tabControl1.TabPages.Remove(tabPage2);
                        button5.Enabled = false;
                        habilitaciones(usuarioLogueado.Id);
                        break;

                    case "administrador":

                        habilitaciones(usuarioLogueado.Id);
                        break;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        ////////////RESIDENTES////////////
        //DAR DE ALTA RESIDENTE
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                ResidenteEntity nuevo = new ResidenteEntity()
                {
                    Id = usuarioLogueado.Id,
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Departamento = txtDepto.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Pref_Notificacion = comboTipoEnvio.Text
                };

                residenteBusiness.AltaResidente(nuevo);


                MessageBox.Show("Residente registrado correctamente.");

                // Deshabilitar alta nuevamente
                button8.Enabled = false;

                // Habilitar editar/eliminar

                button7.Enabled = true;
                buttonEliminar.Enabled = true;

                actualizarDgvResidente();
                CargarComboBoxResidente();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ACTUALIZAR RESIDENTE
        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                ResidenteEntity actualizado = new ResidenteEntity()
                {
                    Id = comboResidente.SelectedValue.ToString(),
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Departamento = txtDepto.Text,
                    Telefono = txtTelefono.Text,
                    Email = txtEmail.Text,
                    Pref_Notificacion = comboTipoEnvio.Text
                };

                residenteBusiness.ActualizarResidente(actualizado);
                MessageBox.Show("Residente actualizado correctamente.");
                actualizarDgvResidente();
                CargarComboBoxResidente();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ELIMINAR RESIDENTE
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                var id = comboResidente.SelectedValue.ToString();

                if (string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("No hay residente seleccionado.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar este residente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.No) return;

                residenteBusiness.EliminarResidente(id);

                MessageBox.Show("Residente eliminado correctamente.");

                comboTipoEnvio.SelectedIndex = -1;

                // Habilitar alta nuevamente
                button8.Enabled = true;

                // Deshabilitar editar/eliminar

                button7.Enabled = false;
                buttonEliminar.Enabled = false;

                actualizarDgvResidente();
                CargarComboBoxResidente();
                actualizarTxtBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message ?? ex.Message);
            }
        }

        ////////////LOCKERS////////////
        //ASOCIAR LOCKER
        private void asociarLocker_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. OBTENER PRIMER LOCKER DISPONIBLE
                var lockerDisponible = lockerBusiness.getAll()
                    .FirstOrDefault(l => l.Estado == "Disponible");

                if (lockerDisponible == null)
                {
                    MessageBox.Show("No hay lockers disponibles.");
                    return;
                }

                // 2. GENERAR CÓDIGO ÚNICO
                lockerDisponible.Codigo_Actual = GenerarCodigoLocker();

                // 3. ASIGNAR RESIDENTE ACTUAL
                lockerDisponible.ResidenteId = usuarioLogueado.Id;

                // 4. OBTENER REPARTIDORES Y ASIGNAR RANDOM
                var repartidores = repartidorBusiness.getAll().ToList();

                if (repartidores.Count == 0)
                {
                    MessageBox.Show("No hay repartidores registrados.");
                    return;
                }

                var random = new Random();
                var repartidorAsignado = repartidores[random.Next(repartidores.Count)];

                lockerDisponible.RepartidorId = repartidorAsignado.Id;

                // 5. MARCAR LOCKER COMO OCUPADO
                lockerDisponible.Estado = "Ocupado";
                lockerDisponible.Fecha_Deposito = DateTime.Now;
                lockerDisponible.Ultima_Mantencion = DateTime.Now;
                lockerDisponible.Tracking_Paquete = "Generado-Automático";

                // 6. GUARDAR EN BASE DE DATOS
                lockerBusiness.ActualizarLoceker(lockerDisponible);

                // 7. NOTIFICAR
                MessageBox.Show($"Locker asignado correctamente.\nCódigo: {lockerDisponible.Codigo_Actual}");

                // 8. REFRESCAR VISTA
                actualizarDgvLockers();
                actualizarTxtBox();
                CargarComboBoxLockers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al asociar locker: " + ex.Message);
            }
        }

        //ELIMINAR LOCKER
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboLockerDelete.SelectedItem == null)
                {
                    MessageBox.Show("Debe seleccionar un locker para eliminar.");
                    return;
                }

                // Obtener el ID desde el comboBox
                int idLocker = (int)comboLockerDelete.SelectedValue;

                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar este locker?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.No)
                    return;

                // Eliminar
                lockerBusiness.EliminarLocker(idLocker);

                MessageBox.Show("Locker eliminado correctamente.");

                // Actualizar pantalla
                actualizarDgvLockers();
                CargarComboBoxLockers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar locker: " + ex.Message);
            }

        }

        //GENERAR QR
        private void GenerarQR_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar selección
                if (comboBoxLockers.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un locker.");
                    return;
                }

                var lockerSeleccionado = (LockerEntity)comboBoxLockers.SelectedItem;

                if (string.IsNullOrEmpty(lockerSeleccionado.Codigo_Actual))
                {
                    MessageBox.Show("El locker no tiene código asignado.");
                    return;
                }

                // 2. GENERAR EL QR
                var qrGenerator = new QRCodeGenerator();
                var qrCodeData = qrGenerator.CreateQrCode(lockerSeleccionado.Codigo_Actual, QRCodeGenerator.ECCLevel.Q);
                var qrCode = new QRCode(qrCodeData);

                Bitmap qrImage = qrCode.GetGraphic(12);

                // Mostrar QR en PictureBox
                Bitmap qrResize = new Bitmap(qrImage, pictureQr.Width, pictureQr.Height);
                pictureQr.Image = qrResize;


                // 3. CAMBIAR ESTADO A ENTREGADO
                lockerSeleccionado.Estado = "Entregado";
                lockerSeleccionado.Tracking_Paquete = "Paquete entregado automáticamente";
                lockerSeleccionado.Ultima_Mantencion = DateTime.Now;

                lockerBusiness.ActualizarLoceker(lockerSeleccionado);

                MessageBox.Show("📦 Locker marcado como ENTREGADO y QR generado correctamente.");

                // 4. Actualizar pantalla
                actualizarDgvLockers();
                actualizarTxtBox();
                CargarComboBoxLockers();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //GENERAR CODIGOLOCKER
        private string GenerarCodigoLocker()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            return (new string(Enumerable.Repeat(chars, 4)
                .Select(s => s[random.Next(s.Length)])
                .ToArray()));

        }


        ////////////REPARTIDORES////////////
        //ELIMINAR REPARTIDOR
        private void buttonEliminarRepartidor_Click_1(object sender, EventArgs e)
        {

            try
            {
                string id = comboRepartidor.SelectedValue.ToString();

                // 1. TRAER REPARTIDOR
                var repartidor = repartidorBusiness.getById(id);

                if (repartidor == null)
                {
                    MessageBox.Show("No se encontró el repartidor.");
                    return;
                }

                // 2. BUSCAR LOCKERS ASOCIADOS
                var lockersAsociados = lockerBusiness.getAll()
                    .Where(l => l.RepartidorId == id)
                    .ToList();

                if (lockersAsociados.Count > 0)
                {
                    // 3. PEDIR CONFIRMACIÓN
                    var confirm = MessageBox.Show(
                        $"⚠ ATENCIÓN ⚠\n\nEste repartidor tiene {lockersAsociados.Count} lockers asociados.\n" +
                        $"¿Desea reasignarlos automáticamente a otro repartidor?",
                        "Repartidor con lockers activos",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.No)
                    {
                        return; // cancela todo
                    }

                    // 4. OBTENER OTROS REPARTIDORES
                    var otrosRepartidores = repartidorBusiness.getAll()
                        .Where(r => r.Id != id)
                        .ToList();

                    if (otrosRepartidores.Count == 0)
                    {
                        MessageBox.Show("No hay otros repartidores disponibles para reasignar los lockers.");
                        return;
                    }

                    // 5. REASIGNAR LOCKERS AUTOMÁTICAMENTE
                    var random = new Random();

                    foreach (var locker in lockersAsociados)
                    {
                        var nuevoRepartidor = otrosRepartidores[random.Next(otrosRepartidores.Count)];

                        locker.RepartidorId = nuevoRepartidor.Id;
                        lockerBusiness.ActualizarLoceker(locker);
                    }

                    MessageBox.Show("Los lockers fueron reasignados correctamente.");
                }

                // 6. ELIMINAR REPARTIDOR
                repartidorBusiness.EliminarRepartidor(id);

                MessageBox.Show("Repartidor eliminado correctamente.");

                // LIMPIAR FORMULARIO
                actualizarTxtBox();
                checkBoxR.Checked = false;

                // ACTUALIZAR GRILLA
                actualizarDgvRepartidor();
                CargarComboBoxRepartidor();


                // DESHABILITAR BOTONES
                buttonEliminarRepartidor.Enabled = false;
                buttonEditarRepartidor.Enabled = false;
                buttonAltaRepartidor.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar repartidor: " + ex.Message);
            }
        }

        //ALTA REPARTIDOR
        private void buttonAltaRepartidor_Click(object sender, EventArgs e)
        {

            try
            {
                RepartidorEntity nuevo = new RepartidorEntity()
                {
                    Id = usuarioLogueado.Id,
                    Nombre = textBoxNombreR.Text,
                    Apellido = txtApellidoR.Text,
                    Empresa = txtEmpresaR.Text,
                    Num_Legajo = txtLegajoR.Text,
                    Telefono = txtTelefonoR.Text,
                    Credencial_Valida = checkBoxR.Checked
                };

                repartidorBusiness.AltaRepartidor(nuevo);

                MessageBox.Show("Repartidor registrado correctamente.");

                // 3. DESHABILITAR ALTA NUEVAMENTE

                buttonAltaRepartidor.Enabled = false;

                // 4. HABILITAR EDITAR / ELIMINAR
                buttonEditarRepartidor.Enabled = true;
                buttonEliminarRepartidor.Enabled = true;

                actualizarDgvRepartidor();
                CargarComboBoxRepartidor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar repartidor: " + ex.Message);
            }

        }

        //EDITAR REPARTIDOR
        private void buttonEditarRepartidor_Click_1(object sender, EventArgs e)
        {
            try
            {
                var repartidor = repartidorBusiness.getById(usuarioLogueado.Id);

                if (repartidor == null)
                {
                    MessageBox.Show("No se encontró el repartidor a editar.");
                    return;
                }

                repartidor.Nombre = textBoxNombreR.Text;
                repartidor.Apellido = txtApellidoR.Text;
                repartidor.Empresa = txtEmpresaR.Text;
                repartidor.Num_Legajo = txtLegajoR.Text;
                repartidor.Telefono = txtTelefonoR.Text;
                repartidor.Credencial_Valida = checkBoxR.Checked;

                repartidorBusiness.EditarRepartidor(repartidor);

                MessageBox.Show("Repartidor actualizado correctamente.");

                CargarComboBoxRepartidor();
                actualizarDgvRepartidor();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar repartidor: " + ex.Message);
            }

        }

        //////////EXIT///////////
        //CERRAR SESION

        //LOCKER_PAGE
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is Login))
                        form.Close();
                }

                Login login = new Login();
                login.FormBorderStyle = FormBorderStyle.None;
                login.Show();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //RESIDENTE_PAGE
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is Login))
                        form.Close();
                }

                Login login = new Login();
                login.FormBorderStyle = FormBorderStyle.None;
                login.Show();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //REPARTIDOR_PAGE
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (!(form is Login))
                        form.Close();
                }

                Login login = new Login();
                login.FormBorderStyle = FormBorderStyle.None;
                login.Show();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }


        /////////////////////////------------------------------//////////////////////////////
        ////////////ACTUALIZACIONES Y VALIDACIONES////////////
        //ACTUALIZAR TXTBOX
        private void actualizarTxtBox()
        {
            try
            {
                textBox1.Text = string.Empty;
                txtNombre.Text = string.Empty;
                textBoxNombreR.Text = string.Empty;
                txtApellido.Text = string.Empty;
                txtApellidoR.Text = string.Empty;
                txtDepto.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtEmpresaR.Text = string.Empty;
                txtLegajoR.Text = string.Empty;
                txtTelefono.Text = string.Empty;
                txtTelefonoR.Text = string.Empty;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        //ACTUALIZAR DATAGRID
        private void actualizarDgvResidente()
        {
            try
            {
                if (usuarioLogueado.Rol.ToLower() != "residente")
                {
                    dataGridViewResidentes.DataSource = null;
                    return;
                }

                var residente = residenteBusiness.getById(usuarioLogueado.Id);

                if (residente == null)
                {
                    dataGridViewResidentes.DataSource = null;
                    return;
                }

                dataGridViewResidentes.DataSource = new List<ResidenteEntity> { residente }
                    .Select(r => new
                    {

                        r.Nombre,
                        r.Apellido,
                        r.Telefono,
                        r.Email,
                        r.Departamento,
                        r.Pref_Notificacion
                    })
                    .ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        //ACTUALIZAR DATAGRID LOCKERS
        private void actualizarDgvLockers()
        {
            try
            {
                var lockers = lockerBusiness.getAll();

                if (usuarioLogueado.Rol.ToLower() == "residente")
                {
                    lockers = lockers
                        .Where(l => l.Residente != null && l.Residente.Id == usuarioLogueado.Id)
                        .ToList();
                }
                else if (usuarioLogueado.Rol.ToLower() == "repartidor")
                {
                    lockers = lockers
                        .Where(l => l.Repartidor != null && l.Repartidor.Id == usuarioLogueado.Id)
                        .ToList();
                }

                dataGridView1.DataSource = lockers.Select(l => new
                {
                    l.Id,
                    l.Ubicacion,
                    l.Tamaño,
                    l.Estado,
                    l.Tracking_Paquete,
                    l.Fecha_Deposito,
                    l.Ultima_Mantencion,
                    l.Codigo_Actual,

                    // Datos del residente asignado  
                    ResidenteNombre = l.Residente?.Nombre,
                    ResidenteApellido = l.Residente?.Apellido,

                    // Datos del repartidor asignado  
                    RepartidorNombre = l.Repartidor?.Nombre,
                    RepartidorApellido = l.Repartidor?.Apellido

                }).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ACTUALIZAR DATAGRID REPARTIDORES
        private void actualizarDgvRepartidor()
        {
            try
            {
                if (usuarioLogueado.Rol.ToLower() != "repartidor")
                {
                    dataGridView3.DataSource = null;
                    return;
                }

                var repartidor = repartidorBusiness.getById(usuarioLogueado.Id);

                if (repartidor == null)
                {
                    dataGridView3.DataSource = null;
                    return;
                }

                dataGridView3.DataSource = new List<RepartidorEntity> { repartidor }
                    .Select(r => new
                    {

                        r.Nombre,
                        r.Apellido,
                        r.Telefono,
                        r.Credencial_Valida,
                        r.Empresa,
                        r.Num_Legajo
                    })
                    .ToList();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }

        //ACTUALIZAR COMBOS LOCKER
        private void CargarComboBoxLockers()
        {
            try
            {

                List<LockerEntity> lockersUsuario = new List<LockerEntity>();

                if (usuarioLogueado.Rol.ToLower() == "residente")
                {
                    lockersUsuario = lockerBusiness.ObtenerLockersDeResidente(usuarioLogueado.Id)
                                                   ?? new List<LockerEntity>();
                }
                comboBoxLockers.DataSource = null;
                comboBoxLockers.DisplayMember = "Ubicacion";
                comboBoxLockers.ValueMember = "Id";
                comboBoxLockers.DataSource = lockersUsuario;
                if (lockersUsuario.Count == 0)
                    comboBoxLockers.SelectedIndex = -1;

                comboLockerDelete.DataSource = null;
                comboLockerDelete.DisplayMember = "Ubicacion";
                comboLockerDelete.ValueMember = "Id";
                comboLockerDelete.DataSource = lockersUsuario;

                if (lockersUsuario.Count == 0)
                    comboLockerDelete.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //ACTUALIZAR COMBOBOX RESIDENTE
        private void CargarComboBoxResidente()
        {
            try
            {
                comboResidente.DataSource = null;
                if (residenteBusiness.getById(usuarioLogueado.Id) == null)
                {
                    comboResidente.SelectedIndex = -1;

                }
                else
                {
                    comboResidente.DataSource = new[]
                    {
                        new {
                           Id = residenteBusiness.getById(usuarioLogueado.Id).Id,
                           Texto = $"{residenteBusiness.getById(usuarioLogueado.Id).Nombre} {residenteBusiness.getById(usuarioLogueado.Id).Apellido} {residenteBusiness.getById(usuarioLogueado.Id).Departamento}"
                        }
                    };
                    comboResidente.DisplayMember = "Texto";
                    comboResidente.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //ACTUALIZAR COMBOBOX REPARTIDOR
        private void CargarComboBoxRepartidor()
        {
            try
            {
                comboRepartidor.DataSource = null;
                if (repartidorBusiness.getById(usuarioLogueado.Id) == null)
                {
                    comboRepartidor.SelectedIndex = -1;

                }
                else
                {
                    comboRepartidor.DataSource = new[]
                    {
                        new {
                           Id = repartidorBusiness.getById(usuarioLogueado.Id).Id,
                           Texto = $"{repartidorBusiness.getById(usuarioLogueado.Id).Nombre} {repartidorBusiness.getById(usuarioLogueado.Id).Apellido} {repartidorBusiness.getById(usuarioLogueado.Id).Empresa}"
                        }
                    };
                    comboRepartidor.DisplayMember = "Texto";
                    comboRepartidor.ValueMember = "Id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //HABILITACIONES DE ROL
        private void habilitaciones(string id)
        {
            try
            {
                // 1) Consultar si ya existe en residentes
                var residente = residenteBusiness.getById(id);

                if (residente != null)
                {
                    txtNombre.Text = residente.Nombre;
                    txtApellido.Text = residente.Apellido;
                    txtDepto.Text = residente.Departamento;
                    txtTelefono.Text = residente.Telefono;
                    txtEmail.Text = residente.Email;
                    comboTipoEnvio.Text = residente.Pref_Notificacion;

                    // Deshabilitar alta
                    button8.Enabled = false;

                    // Habilitar editar / eliminar
                    button7.Enabled = true;
                    buttonEliminar.Enabled = true;
                }
                else
                {
                    // NO EXISTE → Se puede dar de alta
                    button8.Enabled = true;
                    button7.Enabled = false;
                    buttonEliminar.Enabled = false;

                }

                comboTipoEnvio.Items.Clear();
                comboTipoEnvio.Items.AddRange(new[] { "Email", "SMS", "Whatsapp" });

                // 2) Consultar si ya existe en residentes
                var repartidor = repartidorBusiness.getById(id);

                if (repartidor != null)
                {
                    // YA EXISTE → completar datos
                    //textBox16.Text = repartidor.Id;  // AHORA es string, no ToString()

                    textBoxNombreR.Text = repartidor.Nombre;
                    txtApellidoR.Text = repartidor.Apellido;
                    txtEmpresaR.Text = repartidor.Empresa;
                    txtTelefonoR.Text = repartidor.Telefono;
                    txtLegajoR.Text = repartidor.Num_Legajo;
                    checkBoxR.Checked = repartidor.Credencial_Valida;

                    // Deshabilitar alta
                    buttonAltaRepartidor.Enabled = false;

                    // Habilitar editar / eliminar
                    buttonEditarRepartidor.Enabled = true;
                    buttonEliminarRepartidor.Enabled = true;
                }
                else
                {
                    buttonAltaRepartidor.Enabled = true;
                    buttonEliminarRepartidor.Enabled = false;

                    //textBox16.Text = usuarioLogueado.Id;
                }

                // 3) Consultar si ya existe en residentes
                if (usuarioBusiness.getAdmins(usuarioLogueado.Nombre_Usuario, usuarioLogueado.Contraseña) != null)
                {
                    buttonAltaRepartidor.Enabled = true;
                    buttonEliminarRepartidor.Enabled = true;
                    button8.Enabled = true;
                    button7.Enabled = true;
                    buttonEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }
}
