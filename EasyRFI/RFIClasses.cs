using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace EasyRFI
{
    [DataContract]
    public class Perguntas
    {
        public event ErrorEventHandler eventError;

        [DataMember(EmitDefaultValue = false)] public List<Pergunta> perguntas;        

        public Perguntas() { this.perguntas = new List<Pergunta>(); }

        public Perguntas Carregar(string jsonfile)
        {
            try
            {
                //Ler o arquivo json
                StreamReader sReader = new StreamReader(jsonfile);
                string json = sReader.ReadToEnd();
                sReader.Close();

                //Deserializar o json
                Perguntas pergs = new Perguntas();
                var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
                var ser = new DataContractJsonSerializer(typeof(Perguntas));
                pergs = ser.ReadObject(ms) as Perguntas;
                ms.Close();

                return pergs;
            }
            catch (Exception ex)
            {
                if (eventError != null)
                    eventError(this,
                        new ErrorEventArgs(new Exception("Erro: [" + ex.Message + "] ao carregar Perguntas do arquivo: " + jsonfile)));

                return null;
            }
        }

        public int Salvar(string jsonfile)
        {
            try
            {
                var msm = new MemoryStream();
                var serializer = new DataContractJsonSerializer(typeof(Perguntas));
                using (var fs = new FileStream(jsonfile, FileMode.Create))
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, false, true))
                    serializer.WriteObject(writer, this);
                return 1;
            }
            catch (Exception ex)
            {
                if (eventError != null)
                    eventError(this, new ErrorEventArgs(new Exception("Erro: [" + ex.Message + "] ao salvar Perguntas em:  " + jsonfile)));
                return 0;
            }
        }
    }

    [DataContract]
    public class Pergunta
    {
        [DataMember(EmitDefaultValue = false)] public string pergunta;
        [DataMember(EmitDefaultValue = false)] public Regra regra;       
    }   

    [DataContract]
    public class Regra
    {
        [DataMember(EmitDefaultValue = false)] public List<string> produtos;
        [DataMember(EmitDefaultValue = false)] public string aderencia;
        [DataMember(EmitDefaultValue = false)] public string justificativa;
    }

    [DataContract]
    public class Produtos 
    {
        public event ErrorEventHandler eventError;

        [DataMember(EmitDefaultValue = false)] public List<string> produtos;

        public Produtos() { this.produtos = new List<string>(); }

        public Produtos Carregar(string jsonfile)
        {
            try
            {
                //Ler o arquivo json
                StreamReader sReader = new StreamReader(jsonfile);
                string json = sReader.ReadToEnd();
                sReader.Close();

                //Deserializar o json
                Produtos prods = new Produtos();
                var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
                var ser = new DataContractJsonSerializer(typeof(Produtos));
                prods = ser.ReadObject(ms) as Produtos;
                ms.Close();

                return prods;
            }
            catch (Exception ex)
            {
                if (eventError != null)
                    eventError(this,
                        new ErrorEventArgs(new Exception("Erro: [" + ex.Message + "] ao carregar o arquivo: " + jsonfile)));

                return null;
            }
        }

        public int Salvar(string jsonfile)
        {
            try
            {
                var msm = new MemoryStream();
                var serializer = new DataContractJsonSerializer(typeof(Produtos));
                using (var fs = new FileStream(jsonfile, FileMode.Create))
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, false, true))
                    serializer.WriteObject(writer, this);
                return 1;
            }
            catch (Exception ex)
            {
                if (eventError != null)
                    eventError(this, new ErrorEventArgs(new Exception("Erro: [" + ex.Message + "] ao salvar em:  " + jsonfile)));
                return 0;
            }
        }

        public List<Pergunta> Onde_e_Usado(string Produto, Perguntas perguntas)
        {
            List<Pergunta> retorno = new List<Pergunta>();

            foreach (Pergunta perg in perguntas.perguntas)
                if (perg.regra.produtos.Contains(Produto))
                    if (!retorno.Contains(perg))
                        retorno.Add(perg);

            return retorno;
        }
    }

    [DataContract]
    public class Aderencia
    {
        public event ErrorEventHandler eventError;

        [DataMember(EmitDefaultValue = false)] public List<string> aderencia;

        public Aderencia() { this.aderencia = new List<string>(); }

        public Aderencia Carregar(string jsonfile)
        {
            try
            {
                //Ler o arquivo json
                StreamReader sReader = new StreamReader(jsonfile);
                string json = sReader.ReadToEnd();
                sReader.Close();

                //Deserializar o json
                Aderencia ad = new Aderencia();
                var ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
                var ser = new DataContractJsonSerializer(typeof(Aderencia));
                ad = ser.ReadObject(ms) as Aderencia;
                ms.Close();

                return ad;
            }
            catch (Exception ex)
            {
                if (eventError != null)
                    eventError(this,
                        new ErrorEventArgs(new Exception("Erro: [" + ex.Message + "] ao carregar o arquivo: " + jsonfile)));

                return null;
            }
        }

        public int Salvar(string jsonfile)
        {
            try
            {
                var msm = new MemoryStream();
                var serializer = new DataContractJsonSerializer(typeof(Aderencia));
                using (var fs = new FileStream(jsonfile, FileMode.Create))
                using (var writer = JsonReaderWriterFactory.CreateJsonWriter(fs, Encoding.UTF8, false, true))
                    serializer.WriteObject(writer, this);
                return 1;
            }
            catch (Exception ex)
            {
                if (eventError != null)
                    eventError(this, new ErrorEventArgs(new Exception("Erro: [" + ex.Message + "] ao salvar em:  " + jsonfile)));
                return 0;
            }
        }
    }
}
