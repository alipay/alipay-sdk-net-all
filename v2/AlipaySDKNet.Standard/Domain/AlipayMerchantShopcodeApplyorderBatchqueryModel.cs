using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMerchantShopcodeApplyorderBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantShopcodeApplyorderBatchqueryModel : AopObject
    {
        /// <summary>
        /// 支付宝侧生成的开通流水编号，可以通过传入该参数查询指定流水编号的开通状态。
        /// </summary>
        [XmlArray("apply_ids")]
        [XmlArrayItem("string")]
        public List<string> ApplyIds { get; set; }

        /// <summary>
        /// 查询结束时间
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 开通门店码的商户支付宝登录ID，一般为手机号或邮箱
        /// </summary>
        [XmlArray("merchant_login_ids")]
        [XmlArrayItem("string")]
        public List<string> MerchantLoginIds { get; set; }

        /// <summary>
        /// 服务商操作员小二2088
        /// </summary>
        [XmlElement("operator_id")]
        public string OperatorId { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页查询数量，用于翻页查询，每次最多查询100条
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 服务商侧生成的开通流水编号，可以通过传入该参数查询指定流水编号的开通状态。
        /// </summary>
        [XmlArray("request_ids")]
        [XmlArrayItem("string")]
        public List<string> RequestIds { get; set; }

        /// <summary>
        /// 外部间联商户PID，最多可传入100个
        /// </summary>
        [XmlArray("smids")]
        [XmlArrayItem("string")]
        public List<string> Smids { get; set; }

        /// <summary>
        /// 查询开始时间
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
