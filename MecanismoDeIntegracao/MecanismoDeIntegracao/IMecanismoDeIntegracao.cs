using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MecanismoDeIntegracao
{

    [ServiceContract]
    public interface ICliente
    {

        [OperationContract]
        bool AtualizarDados(Cliente cliente);

        [OperationContract]
        List<Cliente> RetornaClientes();

    }


    [DataContract]
    public class Cliente
    {
        int _Cliente_id;
        string _Nome;
        string _TelefoneResidencial;
        string _Endereco;
        DateTime _DataNascimento;
        string _TelefoneCelular;

        [DataMember]
        public string Nome
        {
            get { return _Nome; }
            set { _Nome = value; }
        }

        [DataMember]
        public string TelefoneResidencial
        {
            get { return _TelefoneResidencial; }
            set { _TelefoneResidencial = value; }
        }

        [DataMember]
        public string Endereco
        {
            get { return _Endereco; }
            set { _Endereco = value; }
        }

        [DataMember]
        public DateTime DataNascimento
        {
            get { return _DataNascimento; }
            set { _DataNascimento = value; }
        }

        [DataMember]
        public string TelefoneCelular
        {
            get { return _TelefoneCelular; }
            set { _TelefoneCelular = value; }
        }

        [DataMember]
        public int Cliente_id
        {
            get { return _Cliente_id; }
            set { _Cliente_id = value; }
        }


    }
}
