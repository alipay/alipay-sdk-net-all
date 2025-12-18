using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOverseasTaxTaxdataEvaluateResponse.
    /// </summary>
    public class AlipayOverseasTaxTaxdataEvaluateResponse : AopResponse
    {
        /// <summary>
        /// 收款人对象
        /// </summary>
        [XmlElement("payee")]
        public TaxUserDto Payee { get; set; }

        /// <summary>
        /// 收款人集合
        /// </summary>
        [XmlArray("payees")]
        [XmlArrayItem("tax_user_dto")]
        public List<TaxUserDto> Payees { get; set; }
    }
}
