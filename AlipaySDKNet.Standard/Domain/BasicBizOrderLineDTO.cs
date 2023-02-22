using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BasicBizOrderLineDTO Data Structure.
    /// </summary>
    [Serializable]
    public class BasicBizOrderLineDTO : AopObject
    {
        /// <summary>
        /// 合约编号
        /// </summary>
        [XmlElement("ar_no")]
        public string ArNo { get; set; }

        /// <summary>
        /// 审核备注驳回原因
        /// </summary>
        [XmlElement("audit_memo")]
        public string AuditMemo { get; set; }

        /// <summary>
        /// 后台产品码
        /// </summary>
        [XmlElement("fulfil_product_code")]
        public string FulfilProductCode { get; set; }

        /// <summary>
        /// 订单明细行状态
        /// </summary>
        [XmlElement("order_line_state")]
        public string OrderLineState { get; set; }

        /// <summary>
        /// 前台产品开通号
        /// </summary>
        [XmlElement("pd_open_no")]
        public string PdOpenNo { get; set; }

        /// <summary>
        /// 开通账号列表
        /// </summary>
        [XmlElement("permission_set_code")]
        public string PermissionSetCode { get; set; }

        /// <summary>
        /// 权限集开通号
        /// </summary>
        [XmlElement("permission_set_open_no")]
        public string PermissionSetOpenNo { get; set; }

        /// <summary>
        /// 开通账号列表
        /// </summary>
        [XmlArray("purchaser")]
        [XmlArrayItem("string")]
        public List<string> Purchaser { get; set; }

        /// <summary>
        /// 开通账号类型
        /// </summary>
        [XmlElement("purchaser_type")]
        public string PurchaserType { get; set; }

        /// <summary>
        /// 前台产品码
        /// </summary>
        [XmlElement("sales_product_code")]
        public string SalesProductCode { get; set; }
    }
}
