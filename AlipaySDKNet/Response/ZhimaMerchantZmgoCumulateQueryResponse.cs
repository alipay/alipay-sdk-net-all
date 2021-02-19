using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaMerchantZmgoCumulateQueryResponse.
    /// </summary>
    public class ZhimaMerchantZmgoCumulateQueryResponse : AopResponse
    {
        /// <summary>
        /// 总共累计金额
        /// </summary>
        [XmlElement("aggr_amount")]
        public string AggrAmount { get; set; }

        /// <summary>
        /// 总共累计优惠金额
        /// </summary>
        [XmlElement("aggr_discount_amount")]
        public string AggrDiscountAmount { get; set; }

        /// <summary>
        /// 总共累计次数
        /// </summary>
        [XmlElement("aggr_times")]
        public long AggrTimes { get; set; }

        /// <summary>
        /// 芝麻go协议号，唯一标识一个芝麻go协议。
        /// </summary>
        [XmlElement("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 详情数据列表
        /// </summary>
        [XmlArray("detail_list")]
        [XmlArrayItem("cumulate_data_detail")]
        public List<CumulateDataDetail> DetailList { get; set; }

        /// <summary>
        /// 查询失败原因
        /// </summary>
        [XmlElement("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 分页参数，返回传入的值。
        /// </summary>
        [XmlElement("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页参数，返回传入的值。
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }
    }
}
