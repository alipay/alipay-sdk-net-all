using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntMerchantExpandMembercardTransactionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntMerchantExpandMembercardTransactionBatchqueryModel : AopObject
    {
        /// <summary>
        /// 交易明细类型，指定要查询的明细类型，枚举如下： RECHARGE=充值， PAYMENT=支付， REFUND=退款， RETURN=退卡
        /// </summary>
        [XmlArray("biz_type")]
        [XmlArrayItem("string")]
        public List<string> BizType { get; set; }

        /// <summary>
        /// 查询结束时间，格式"yyyy-MM-dd HH:mm:ss"，查询时间范围最大为30天
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 商家的安心充配置的唯一编号
        /// </summary>
        [XmlElement("member_product_id")]
        public string MemberProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，指定则查询指定用户的交易记录，不指定则查所有用户的交易记录
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 查询的页数，从1开始，最大1000
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，最小1，最大20
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询开始时间，格式"yyyy-MM-dd HH:mm:ss"，查询时间范围最大为30天
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID，指定则查询指定用户的交易记录，不指定则查所有用户的交易记录
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
