using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Validaciones
{
     static public class MetodosComunes
    {
        static public KeyPressEventArgs KeyPressPuntoyComa(KeyPressEventArgs e, string TEXTO)
        {

            if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
            {
                //si el texto ya contiene coma no lo pone
                if (TEXTO.Contains(",") == false && TEXTO.Length != 0)
                {
                    e.KeyChar = Convert.ToChar(",");
                }
                else
                {
                    //hace que no ponga nada
                    e.Handled = true;
                }
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
            return e;
        }

        static public KeyPressEventArgs KeyPressSiempreComa(KeyPressEventArgs e)
        {

            if (e.KeyChar.ToString() == "." || e.KeyChar.ToString() == ",")
            {
                e.KeyChar = Convert.ToChar(",");
            }
            return e;
        }

        static public KeyPressEventArgs KeyPressNumerosIonMedio(KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "-" || e.KeyChar.ToString() == "/")
            {
                if (e.KeyChar.ToString() == "-")
                {
                    e.KeyChar = Convert.ToChar("-");
                }
            }
            else
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            return e;
        }

        /// Encripta una cadena
        public static string EncriptarPassBD(string cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptarPassBD(string cadenaAdesencriptar)
        {
            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        static public KeyPressEventArgs KeyPressSoloLetras(KeyPressEventArgs e, string TEXTO)
        {

            if (Char.IsLetter(e.KeyChar))//solo letras
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))//solo backspace, space, delete, etc.
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))// solo .:;,_- (simbolos de punt
            {
                e.Handled = false;
            }
            else if (Char.IsSymbol(e.KeyChar))//demas caracteres
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))//espacio
            {
                e.Handled = false;
            }
            else//que el resto no lo escriba
            {
                e.Handled = true;
            }
            return e;
        }

        static public bool ValidacionEMAIL(string Mail)//validacion formato de direccion de e-mail
        {

            Regex mRegxExpression;

            if (Mail.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");

                if (!mRegxExpression.IsMatch(Mail.Trim()))
                {
                    //no es correcta
                    return false;
                }
                else
                {
                    //es correcta
                    return true;
                }

            }
            else
            {
                //no es correcta, esta vacia
                return false;
            }

        }

        static public bool ValidacionUsuario(string usuario)
        {
            Regex validadcion = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{5,10})$");
            if (validadcion.IsMatch(usuario))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static public bool ValidacionPASSWORD(string pass)//validacion formato de password
        {
            Regex validadcion = new Regex(@"(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8,15})$");
            if (validadcion.IsMatch(pass))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public bool ValidacionWWW(string web)//validacion formato de direccion web
        {

            Regex mRegxExpression;

            if (web.Trim() != string.Empty)
            {

                mRegxExpression = new Regex(@"\A[w]{3}(\.)[a-z0-9]+(\.)(com|net|info|org|edu|gob)\Z");

                if (!mRegxExpression.IsMatch(web.Trim()))
                {
                    //Direccion web incorrecta
                    return false;
                }
                else
                {
                    //Direccion Correcta
                    return true;
                }
            }
            else
            {
                //Direccion web incorrecta o vacia
                return false;
            }

        }

        static public bool ValidaURL(string url)
        {
            Uri uri = null;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri) || null == uri)
            {
                //URL incorrecta
                return false;
            }
            else
            {
                //URL Correcta
                return true;
            }
        }

        static public bool ValidaDNI(string dni)
        {

            if (Regex.Match(dni, @"^[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]$").Success == true)
            {
                //dni correcto
                return true;
            }
            else
            {
                //dni incorrecto
                return false;
            }
        }

        static public bool ValidatarjetaCredito(string tarjeta)
        {
            Regex Val = new Regex(@"^((67\d{2})|(4\d{3})|(5[1-5]\d{2})|(6011))(-?\s?\d{4}){3}|(3[4,7])\ d{2}-?\s?\d{6}-?\s?\d{5}$");
            if (Val.IsMatch(tarjeta))
            {
                //Tarjeta de credito Valida
                return true;
            }
            else
            {
                //Tarjeta de credito no valida
                return false;
            }
        }

        static public bool ValidaCodigoPostal(string cp)
        {
            Regex Val = new Regex(@"^([1-9]{2}|[0-9][1-9]|[1-9][0-9])[0-9]{3}$");
            if (Val.IsMatch(cp))
            {
                //Codigo Postal correcto
                return true;
            }
            else
            {
                //Codigo postal incorrecto
                return false;
            }
        }

        #region LOG

        static public void RegistrarLog(string mensaje)
        {

            string PATHLOG = @"C:\Log\";
            string ARCHIVOLOG = "ArchivoLog" + Devuelveaaaammdd() + ".txt";

            StreamWriter sw;
            string pathCompleto = PATHLOG + @"\" + ARCHIVOLOG;
            var dirInfo = new DirectoryInfo(PATHLOG);
            if (!dirInfo.Exists)
            {
                Directory.CreateDirectory(PATHLOG);
            }

            if (File.Exists(pathCompleto))
            {
                sw = File.AppendText(pathCompleto);
            }
            else
            {
                sw = File.CreateText(pathCompleto);
            }
            sw.WriteLine("-------------------------------------------------------------------------------");
            sw.WriteLine("Se ha producido un error. " + DateTime.Now.ToString());
            sw.WriteLine("-------------------------------------------------------------------------------");
            sw.WriteLine("");
            sw.WriteLine("MENSAJE: " + mensaje);
            sw.Close();


            System.Text.StringBuilder CuerpoMail = new System.Text.StringBuilder();
            CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
            CuerpoMail.AppendLine("Se ha producido un error. " + DateTime.Now.ToString());
            CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
            CuerpoMail.AppendLine("");
            CuerpoMail.AppendLine("MENSAJE: " + mensaje);


            EnviarMail(CuerpoMail, "ERROR");
        }

        private static int Devuelveaaaammdd()
        {
            string aaaammddhhmmss = "";
            DateTime FechaNow = DateTime.Now;
            aaaammddhhmmss = FechaNow.ToString("yyyyMMdd");

            return Convert.ToInt32(aaaammddhhmmss);
        }

        #endregion

        #region MAIL

        public static bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public static void EnviarMail(StringBuilder CuerpoMail, string TIPO)
        {
            try
            {
                SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

                server.Credentials = new System.Net.NetworkCredential("lucas.malvasia@gmail.com", "infierno12");
                server.EnableSsl = true;
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                MailMessage correoElectronico = new MailMessage();

                string mailTo = "";
                string mailTo2 = "";
                switch (TIPO)
                {
                    case "ERROR": mailTo = "luqqazz.cs@hotmail.com"; mailTo2 = "danielagu@hotmail.com.ar"; break;// a quien se lo envia. el para
                    case "EXITO": mailTo = "xxx@gmail.com"; mailTo2 = "xxx@gmail.com"; break;// a quien se lo envia. el para
                    case "ADVERTENCIA": mailTo = "xxx@gmail.com"; mailTo2 = "xxx@gmail.com"; break;// a quien se lo envia. el para
                    default:
                        break;
                }
                correoElectronico.Subject = "LOG: ";

                correoElectronico.To.Add(new MailAddress(mailTo));
                if (mailTo2 != "")
                {
                    correoElectronico.To.Add(new MailAddress(mailTo2));
                }
                correoElectronico.From = new MailAddress("lucas.malvasia@gmail.com", "Lucas Malvasia");

                ///* Si deseamos Adjuntar algún archivo*/
                //correoElectronico.Attachments.Add(new Attachment(@ruta));

                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                CuerpoMail.AppendLine("Enviado desde lucas.malvasia@gmail.com");
                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                correoElectronico.Body = CuerpoMail.ToString();

                /* Enviar - MandarCorreo()*/
                server.Send(correoElectronico);

                //MessageBox.Show("El Mail se ha Enviado Correctamente", "Listo!!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


            }
            catch (Exception ex)
            {
                return;
            }
        }

        public static bool funConexion()
        {
            System.Net.HttpWebRequest req;

            System.Net.HttpWebResponse res;

            try
            {
                req = (System.Net.HttpWebRequest)
                //probar con destelnorte.com.ar
                System.Net.WebRequest.Create(@"http://google.com ");

                res = (System.Net.HttpWebResponse)req.GetResponse();

                req.Abort();

                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch// (System.Net.WebException e) 
            {
                return false;
            }
        }

        #endregion

        public static void OnlyNumbers(KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        public static void OnlyLetters(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
                return;
            }
        }
        public static bool ValidaEdad(DateTime nacimiento, int edadingresada)
        {
            int edad = (DateTime.Now.Subtract(nacimiento).Days / 365);
            if (edad == edadingresada)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void SololetrasyNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
                return;
            }
        }
        public static void SoloNumerosyunacoma(KeyPressEventArgs e, object sender)
        {
            if ((sender as TextBox).Text.Contains(","))
            {
                if (!char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
                if (e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '\b')
                {
                    MessageBox.Show("Solo se permiten numeros y una coma", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                }
                if (e.KeyChar == ',' || e.KeyChar == '\b')
                {
                    e.Handled = false;
                }
            }
        }
        public static bool ValidaCuit(string cuit)
        {
            if (cuit == null)
            {
                return false;
            }
            //Quito los guiones, el cuit resultante debe tener 11 caracteres.
            cuit = cuit.Replace("-", string.Empty);
            if (cuit.Length != 11)
            {
                return false;
            }
            else
            {
                int calculado = CalcularDigitoCuit(cuit);
                int digito = int.Parse(cuit.Substring(10));
                return calculado == digito;
            }
        }

        public static int CalcularDigitoCuit(string cuit)
        {
            int[] mult = new[] { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2 };
            char[] nums = cuit.ToCharArray();
            int total = 0;
            for (int i = 0; i < mult.Length; i++)
            {
                total += int.Parse(nums[i].ToString()) * mult[i];
            }
            var resto = total % 11;
            return resto == 0 ? 0 : resto == 1 ? 9 : 11 - resto;
        }
        public static string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
        public static void EnviarPassword(string Password, string mail)
        {
            try
            {
                SmtpClient server = new SmtpClient("smtp.gmail.com", 587);

                server.Credentials = new System.Net.NetworkCredential("lucas.malvasia@gmail.com", "infierno12");
                server.EnableSsl = true;
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

                MailMessage correoElectronico = new MailMessage();

                string mailTo = mail;
                correoElectronico.Subject = "Nueva clave del sistema";

                correoElectronico.To.Add(new MailAddress(mailTo));
                correoElectronico.From = new MailAddress("lucas.malvasia@gmail.com", "Lucas Malvasia");

                System.Text.StringBuilder CuerpoMail = new System.Text.StringBuilder();
                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                CuerpoMail.AppendLine(DateTime.Now.ToString());
                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                CuerpoMail.AppendLine("Se ha generado una nueva clave para el usuario");
                CuerpoMail.AppendLine("La clave es: " + Password);
                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                CuerpoMail.AppendLine("Enviado desde lucas.malvasia@gmail.com");
                CuerpoMail.AppendLine("-------------------------------------------------------------------------------");
                correoElectronico.Body = CuerpoMail.ToString();

                /* Enviar - MandarCorreo()*/
                server.Send(correoElectronico);

                MessageBox.Show("La clave fue enviada al correo del usuario", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception ex)
            {
                return;
            }
        }
    }
}