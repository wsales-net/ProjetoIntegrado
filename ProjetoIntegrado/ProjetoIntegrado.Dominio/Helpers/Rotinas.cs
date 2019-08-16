using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace ProjetoIntegrado.Dominio.Helpers
{
    public static class Rotinas
    {
        public static IComparable GetPropertyByName<T>(string propertyName, T item) where T : class
        {
            return (IComparable)typeof(T).GetProperty(propertyName).GetValue(item, null);
        }

        public static IComparable GetPropertyByIndex<T>(int index, T item) where T : class
        {
            var i = 0;
            PropertyInfo propriedadeSort = null;
            foreach (var propriedade in typeof(T).GetProperties())
            {
                if (i == index)
                {
                    propriedadeSort = propriedade;
                    break;
                }
                i++;
            }
            return GetPropertyByName(propriedadeSort.Name, item);
        }

        public static decimal TratarDecimal(decimal? valor, decimal valorSeNulo = 0)
        {
            return (valor == null) ? valorSeNulo : (decimal)valor;
        }

        public static decimal ToDecimal(this string value)
        {
            return Convert.ToDecimal(value);
        }

        public static decimal Truncate(decimal d, int precision)
        {
            var factor = 1.0m;
            for (int i = 0; i < precision; i++)
                factor *= 10.0m;
            return Math.Truncate(factor * d) / factor;
        }

        public static DateTime? ToDateTime(this string data, string formato = "dd/MM/yyyy")
        {
            DateTime? dataRetorno = null;
            if (!string.IsNullOrEmpty(data))
            {
                DateTime dataConvertida;
                if (DateTime.TryParseExact(data, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out dataConvertida))
                {
                    dataRetorno = dataConvertida;
                }
            }

            if (dataRetorno.HasValue && dataRetorno < new DateTime(1800, 1, 1))
            {
                return null;
            }

            return dataRetorno;
        }

        public static string ToDateDto(this DateTime? data)
        {
            return data == null ? "" : Convert.ToDateTime(data).ToShortDateString();
        }

        public static string ToDateDto(this DateTime? data, string mascara)
        {
            return data == null ? "" : Convert.ToDateTime(data).ToString(mascara);
        }

        public static string ToDateDto(this DateTime data)
        {
            return Convert.ToDateTime(data).ToShortDateString();
        }

        public static string ToDateDto(this DateTime data, string mascara)
        {
            return Convert.ToDateTime(data).ToString(mascara);
        }

        public static string ToStringSemDecimais(this decimal valor)
        {
            return string.Format("{0:0}", valor);
        }

        public static string ToStringSemDecimais(this decimal? valor)
        {
            if (!valor.HasValue)
            {
                valor = 0;
            }

            return string.Format("{0:0}", valor);
        }

        public static string ToStringDto(this bool valor, bool uppercase = false)
        {
            var retorno = valor ? "sim" : "não";
            if (uppercase)
            {
                retorno = retorno.ToUpper();
            }
            return retorno;
        }

        public static string ToStringDto(this decimal? valor)
        {
            if (!valor.HasValue)
            {
                valor = 0;
            }
            return Convert.ToDecimal(valor).ToString("N2");
        }

        public static string ToStringDto(this decimal valor)
        {
            return valor.ToString("N2");
        }

        public static string ToStringDto(this double valor)
        {
            return Convert.ToDecimal(valor).ToString("N2");
        }

        public static string ToStringDto(this string valor)
        {
            var posPonto = valor.LastIndexOf(".", StringComparison.CurrentCulture);
            var posVirgula = valor.LastIndexOf(",", StringComparison.CurrentCulture);
            decimal valorDecimal;

            if (posPonto > 0 && posVirgula > 0)
            {
                valor = posPonto > posVirgula ? valor.Replace(",", "") : valor.Replace(".", "").Replace(",", ".");
            }
            else
            {
                if (posVirgula > 0)
                {
                    valor = valor.Replace(",", ".");
                }
            }

            return !decimal.TryParse(valor, NumberStyles.Any, CultureInfo.InvariantCulture, out valorDecimal) ? "0" : valorDecimal.ToStringDto();
        }

        public static string ToDateTimeDto(this DateTime? data)
        {
            return data == null ? "" : Convert.ToDateTime(data).ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ToDateTimeDto(this DateTime data)
        {
            return data.ToString("dd/MM/yyyy HH:mm:ss");
        }

        public static string ToDatePicker(this DateTime data)
        {
            return data.ToString("MM/dd/yyyy");
        }

        public static string ToDatePicker(this DateTime? data)
        {
            return data.HasValue ? Convert.ToDateTime(data).ToDatePicker() : "";
        }

        public static string ToIntDto(this int? valor)
        {
            return valor == null ? "" : valor.ToString();
        }

        public static string ToDecimalDto(this decimal? valor)
        {
            return valor == null ? "" : valor.ToString();
        }

        public static string RemoverMascaraCnpj(this string cnpj)
        {
            return "";
            //return (string.IsNullOrEmpty(cnpj)) ? "" : cnpj.UnmaskCnpj();
        }

        public static string RemoverMascaraCpf(this string cpf)
        {
            return "";
            //return (string.IsNullOrEmpty(cpf)) ? "" : cpf.UnmaskCpf();
        }

        public static string RemoverMascaraCep(this string cep)
        {
            return "";
            //return (string.IsNullOrEmpty(cep)) ? "" : cep.UnmaskCep();
        }

        public static int DaysBetween(DateTime dataInicial, DateTime dataFinal)
        {
            return (int)(dataFinal - dataInicial).TotalDays;
        }

        public static string GetRandomString()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, 15)
                                        .Select(s => s[random.Next(s.Length)])
                                        .ToArray());
        }

        public static bool DateInRange(DateTime date, DateTime dataInicial, DateTime dataFinal)
        {
            return date >= dataInicial && date <= dataFinal;
        }

        public static string GetFileHash(byte[] fileContent)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var buffer = md5.ComputeHash(fileContent);
                var sb = new StringBuilder();
                for (var i = 0; i < buffer.Length; i++)
                {
                    sb.Append(buffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static string GetFileHash(string filename)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                var buffer = md5.ComputeHash(File.ReadAllBytes(filename));
                var sb = new StringBuilder();
                for (var i = 0; i < buffer.Length; i++)
                {
                    sb.Append(buffer[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }

        public static Guid? ToGuid(this string entrada)
        {
            Guid saida;
            if (!Guid.TryParse(entrada, out saida))
            {
                return null;
            }
            return saida;
        }

        public static string MaskTelefoneRelatorio(string telefone)
        {
            telefone = telefone.Trim();
            var length = telefone.Length;
            var ddd = string.Empty;
            var pref = string.Empty;
            var suf = string.Empty;
            var mask = string.Empty;

            if (length == 10)
            {
                ddd = telefone.Substring(0, 2);
                pref = telefone.Substring(2, 4);
                suf = telefone.Substring(6, 4);
                mask = "{0} {1}-{2}";
            }
            else if (length == 11)
            {
                ddd = telefone.Substring(0, 2);
                pref = telefone.Substring(2, 5);
                suf = telefone.Substring(7, 4);
                mask = "{0} {1}-{2}";
            }
            else
            {
                return telefone;
            }

            return string.Format(mask, ddd, pref, suf);
        }

        public static string GetTimestamp(this DateTime value)
        {
            return value.ToString("yyyyMMddHHmmss");
        }

        public static bool IsNullOrEmptyTrim(this string value)
        {
            return string.IsNullOrEmpty(value) || string.IsNullOrEmpty(value.Trim());
        }

        public static DateTime PrimeiroDiaMes()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
        }

        public static DateTime UltimoDiaMes()
        {
            return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month));
        }

        public static string LetrasAleatorias(int length)
        {
            var random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray()).ToLower();
        }

        public static string NumerosAleatorios(int length)
        {
            var random = new Random();
            const string chars = "0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string CaracteresEspeciaisAleatorios(int length)
        {
            var random = new Random();
            const string chars = "!@#$%&*";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public static string RemoverAcentos(this string texto)
        {
            var sbReturn = new StringBuilder();
            var arrayText = texto.Normalize(NormalizationForm.FormD).ToCharArray();
            foreach (var letter in arrayText)
            {
                if (CharUnicodeInfo.GetUnicodeCategory(letter) != UnicodeCategory.NonSpacingMark)
                    sbReturn.Append(letter);
            }
            return sbReturn.ToString();
        }

        public static bool IsNullOrZero(this int? value)
        {
            return (value ?? 0) == 0;
        }

        public static bool IsNullOrZero(this decimal? value)
        {
            return (value ?? 0) == 0;
        }

        public static int YearsBetween(DateTime a, DateTime b)
        {
            var zeroTime = new DateTime(1, 1, 1);
            var span = b - a;
            var years = (zeroTime + span).Year - 1; // Because we start at year 1 for the Gregorian calendar, we must subtract a year here.
            return years;
        }

        public static string Capitalize(this string value)
        {
            return value.IsNullOrEmptyTrim() ? "" : value.First().ToString().ToUpper() + value.Substring(1);
        }

        public static int MonthsBetween(DateTime dataInicial, DateTime dataFinal)
        {
            return ((dataFinal.Year - dataInicial.Year) * 12) + dataFinal.Month - dataInicial.Month;
        }

        public static bool PeriodoDataValido(DateTime? dataInicio, DateTime? dataFim, bool obrigatorio = true)
        {
            if (!dataInicio.HasValue && !dataFim.HasValue)
            {
                return !obrigatorio;
            }

            if (dataInicio.HasValue && !dataFim.HasValue || !dataInicio.HasValue)
            {
                return false;
            }

            return dataInicio.Value.Date <= dataFim.Value.Date;
        }

        public static string NullIfEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str) ? null : str;
        }

        public static string Aggregate(this IList<string> lista)
        {
            return "";
            //var mensagemLog = "";

            //return lista.IsNullOrEmpty()
            //    ? ""
            //    : lista.Aggregate(mensagemLog, (current, menssagem) => current + ("\n" + menssagem));
        }

        public static string Descaracterizar(this string value, int exibirCaracteres, char valorPreenchimento, IList<char> excecoes, int? tamanhoMaximoTexto)
        {
            if (value.IsNullOrEmptyTrim() && tamanhoMaximoTexto.HasValue) return "".PadRight((int)tamanhoMaximoTexto, valorPreenchimento);
            if (value.IsNullOrEmptyTrim() && !tamanhoMaximoTexto.HasValue) return "";

            if (excecoes == null) excecoes = new List<char>();
            if (!tamanhoMaximoTexto.HasValue) tamanhoMaximoTexto = value.Length;

            var valorRetorno = "";
            var valueLenth = value.Length > tamanhoMaximoTexto ? tamanhoMaximoTexto : value.Length;

            for (var i = 0; i < valueLenth; i++)
            {
                valorRetorno += (i < exibirCaracteres)
                    ? value[i]
                    : excecoes.Contains(value[i])
                        ? value[i]
                        : valorPreenchimento;
            }

            return valorRetorno.PadRight((int)tamanhoMaximoTexto, valorPreenchimento);
        }

        /// <summary>
        ///   Ex.: Cpf 111.222.333-44
        ///        parametros-> separador = new char[]{'.','-'};
        ///                     valorPreenchimento = '*';
        ///                     blocoPreservado = new int[]{1,3}
        ///        Resultado: 111.***.333-**
        /// </summary>
        /// <param name="value"></param>
        /// <param name="separador"></param>
        /// <param name="valorPreenchimento"></param>
        /// <param name="blocoPreservado"></param>
        public static string Descaracterizar(this string value, char[] separador, char valorPreenchimento, int[] blocoPreservado)
        {
            if (value.IsNullOrEmptyTrim()) return string.Empty;

            if (separador == null) separador = new char[] { };

            var resultado = string.Empty;
            var iBloco = 1;
            foreach (var caracter in value)
            {
                if ((separador.Length > 0) && (separador.Contains(caracter)))
                {
                    resultado += caracter;
                    iBloco++;
                    continue;
                }

                if ((blocoPreservado.Length > 0) && (blocoPreservado.Contains(iBloco)))
                {
                    resultado += caracter;
                    continue;
                }

                resultado += valorPreenchimento;
            }

            return resultado;
        }

        public static string DescaracterizarCpfCnpj(this string value)
        {
            return value.Descaracterizar(new[] { '.', '-', '/' }, '*', new int[] { });
        }

        public static string DescaracterizarEmail(this string value)
        {
            return value.Descaracterizar(new[] { '@' }, '*', new[] { 2 });
        }

        public static string DescaracterizarData(this string value)
        {
            return value.Descaracterizar(new[] { '/' }, '*', new int[] { });
        }

        public static string DescaracterizarTelefone(this string value)
        {
            if (value.IsNullOrEmptyTrim()) return value;

            return value.ExtrairNumeros().Replace(" ", "").Insert(value.Length - 4, " ").Descaracterizar(new[] { ' ' }, '*', new[] { 2 });
        }

        public static string ExtrairNumeros(this string str)
        {
            var sb = new StringBuilder();
            foreach (Match m in Regex.Matches(str, @"\d"))
            {
                sb.Append(m);
            }

            return sb.ToString();
        }

        public static DateTime UltimoMomento(this DateTime data)
        {
            return data.AddDays(1).AddTicks(-1);
        }
        public static string ToTimeDto(this TimeSpan hora)
        {
            return hora.ToString(@"hh\:mm");
        }
    }
}
