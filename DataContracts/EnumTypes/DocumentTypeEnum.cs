﻿using System.Runtime.Serialization;

namespace GatewayApiClient.DataContracts.EnumTypes {

    /// <summary>
    /// Tipo de documento
    /// </summary>
    [DataContract]
    public enum DocumentTypeEnum {

        /// <summary>
        /// Cadastro de pessoa física
        /// </summary>
        [EnumMember]
        CPF = 1,

        /// <summary>
        /// Cadastro de pessoa jurídica
        /// </summary>
        [EnumMember]
        CNPJ = 2
    }
}