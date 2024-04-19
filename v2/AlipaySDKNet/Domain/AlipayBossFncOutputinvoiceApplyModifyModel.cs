using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayBossFncOutputinvoiceApplyModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBossFncOutputinvoiceApplyModifyModel : AopObject
    {
        /// <summary>
        /// 当前该接口的操作人，用于权限校验，校验登录人与预览提交人是否一致
        /// </summary>
        [XmlElement("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 预览发票并编辑后的发票票面信息
        /// </summary>
        [XmlArray("output_invoice_previewed_orders")]
        [XmlArrayItem("open_api_output_invoice_previewed_order")]
        public List<OpenApiOutputInvoicePreviewedOrder> OutputInvoicePreviewedOrders { get; set; }

        /// <summary>
        /// 预览请求Id，用于查询数据库中保存的发票预览信息
        /// </summary>
        [XmlElement("preview_order_id")]
        public string PreviewOrderId { get; set; }
    }
}
