using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceEcJointaccountbillDetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceEcJointaccountbillDetailBatchqueryModel : AopObject
    {
        /// <summary>
        /// 业务场景。不传默认为ISV_DEFAULT
        /// </summary>
        [XmlElement("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 截止日期。支持yyyy-MM-dd和yyyy-MM-dd HH:mm:ss两种格式
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        [XmlElement("enterprise_id")]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 页数。本参数为空或小于1默认显示第一页；如果输入的值大于总页数，则返回最后一页数据。
        /// </summary>
        [XmlElement("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页大小。本参数为空或小于1默认20条；超过20条默认按20条查询；不足20条则按实际记录数返回。
        /// </summary>
        [XmlElement("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 起始日期。支持yyyy-MM-dd和yyyy-MM-dd HH:mm:ss两种格式
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 员工支付宝UID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
