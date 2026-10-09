using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcRecyclinginvoiceCompanyQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcRecyclinginvoiceCompanyQueryModel : AopObject
    {
        /// <summary>
        /// 企业（商户）税号
        /// </summary>
        [XmlElement("tax_no")]
        public string TaxNo { get; set; }

        /// <summary>
        /// 如果企业有校验异常,企业信息查询会将校验失败的异常信息返回,校验成功则返回空数组;该参数为true代表更新企业校验信息,为false或者不传该参数只返回校验失败信息
        /// </summary>
        [XmlElement("update_check_info")]
        public bool UpdateCheckInfo { get; set; }
    }
}
