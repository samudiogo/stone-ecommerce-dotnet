﻿using System;
using System.Runtime.Serialization;
using GatewayApiClient.DataContracts.EnumTypes;

namespace GatewayApiClient.DataContracts {

    /// <summary>
    /// Dados da transação do boleto
    /// </summary>
    [DataContract(Name = "BoletoTransactionData", Namespace = "")]
    public class BoletoTransactionData {

        /// <summary>
        /// Url para visualização do boleto
        /// </summary>
        [DataMember]
        public string BoletoUrl { get; set; }

        /// <summary>
        /// Código de barras do boleto
        /// </summary>
        [DataMember]
        public string Barcode { get; set; }

        #region BoletoTransactionStatus

        /// <summary>
        /// Status do boleto
        /// </summary>
        [DataMember(Name = "BoletoTransactionStatus")]
        private string BoletoTransactionStatusField {
            get {
                return this.BoletoTransactionStatus.ToString();
            }
            set {
                this.BoletoTransactionStatus = (BoletoTransactionStatusEnum)Enum.Parse(typeof(BoletoTransactionStatusEnum), value);
            }
        }

        /// <summary>
        /// Status do boleto
        /// </summary>
        public BoletoTransactionStatusEnum BoletoTransactionStatus { get; set; }

        #endregion

        /// <summary>
        /// Chave da transação. Utilizada para identificar a transação de boleto no gateway
        /// </summary>
        [DataMember]
        public Guid TransactionKey { get; set; }

        /// <summary>
        /// Valor original do boleto em centavos
        /// </summary>
        [DataMember]
        public long AmountInCents { get; set; }

        /// <summary>
        /// Número do documento
        /// </summary>
        [DataMember]
        public string DocumentNumber { get; set; }

        /// <summary>
        /// Identificador da transação no sistema da loja
        /// </summary>
        [DataMember]
        public string TransactionReference { get; set; }

        #region ExpirationDate

        /// <summary>
        /// Data de expiração do boleto
        /// </summary>
        [DataMember(Name = "ExpirationDate")]
        private string ExpirationDateField {
            get {
                if (this.ExpirationDate == null) { return null; }
                return this.ExpirationDate.Value.ToString(ServiceConstants.DATE_TIME_FORMAT);
            }
            set {
                if (value == null) {
                    this.ExpirationDate = null;
                }
                else {
                    this.ExpirationDate = DateTime.ParseExact(value, ServiceConstants.DATE_TIME_FORMAT, null);
                }
            }
        }

        /// <summary>
        /// Data de expiração do boleto
        /// </summary>
        public Nullable<DateTime> ExpirationDate { get; set; }

        #endregion

        /// <summary>
        /// Número do banco
        /// </summary>
        [DataMember]
        public string BankNumber { get; set; }

        /// <summary>
        /// Valor total pago em centavos
        /// </summary>
        [DataMember]
        public Nullable<long> AmountPaidInCents { get; set; }

        #region CreateDate

        /// <summary>
        /// Data de criação do boleto no gateway
        /// </summary>
        [DataMember(Name = "CreateDate")]
        private string CreateDateField {
            get {
                return this.CreateDate.ToString(ServiceConstants.DATE_TIME_FORMAT);
            }
            set {
                this.CreateDate = DateTime.ParseExact(value, ServiceConstants.DATE_TIME_FORMAT, null);
            }
        }

        /// <summary>
        /// Data de criação do boleto no gateway
        /// </summary>
        public DateTime CreateDate { get; set; }

        #endregion

        /// <summary>
        /// Identificador do boleto
        /// </summary>
        [DataMember]
        public string NossoNumero { get; set; }
    }
}