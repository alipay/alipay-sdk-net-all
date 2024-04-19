using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenAppRateDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenAppRateDataSyncModel : AopObject
    {
        /// <summary>
        /// 账单号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 管控状态
        /// </summary>
        [XmlElement("control_status")]
        public long ControlStatus { get; set; }

        /// <summary>
        /// 支付宝用户信息: in_biz_account和out_biz_account必须要有一个
        /// </summary>
        [XmlElement("in_biz_account")]
        public string InBizAccount { get; set; }

        /// <summary>
        /// 操作类型.INSERT:插入,UPDATE:更新
        /// </summary>
        [XmlElement("oper_type")]
        public string OperType { get; set; }

        /// <summary>
        /// 业务私域用户信息：in_biz_account和out_biz_account必须要有一个
        /// </summary>
        [XmlElement("out_biz_account")]
        public string OutBizAccount { get; set; }

        /// <summary>
        /// 评价ID：type=Rated时必填
        /// </summary>
        [XmlElement("rate_id")]
        public string RateId { get; set; }

        /// <summary>
        /// 评分：type=NotRated时必填
        /// </summary>
        [XmlElement("score")]
        public long Score { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [XmlElement("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 评价来源.KOUBEI:口碑,MINIAPP:小程序,OFFLINE:线下门店
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 数据类型.Rated:评价完成消息,NotRated:逾期未评价信息
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }
    }
}
