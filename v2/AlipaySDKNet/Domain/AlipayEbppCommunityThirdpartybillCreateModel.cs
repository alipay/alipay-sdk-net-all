using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayEbppCommunityThirdpartybillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppCommunityThirdpartybillCreateModel : AopObject
    {
        /// <summary>
        /// 待缴账单通知用户 Uid 
        /// </summary>
        [XmlElement("alipay_uid")]
        public string AlipayUid { get; set; }

        /// <summary>
        /// 待缴费金额，正数 单位:分 如欠费 200.20 元，则传入 20020
        /// </summary>
        [XmlElement("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 账单详情地址 长度限制
        /// </summary>
        [XmlElement("bill_detail_url")]
        public string BillDetailUrl { get; set; }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        [XmlElement("bill_end_time")]
        public string BillEndTime { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [XmlElement("bill_start_time")]
        public string BillStartTime { get; set; }

        /// <summary>
        /// 待缴账单业务流水号 通过该字段幂等。 相同服务商下传入相同 bizNo 视为相同请求。
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// T 业主绑定房间号。对应先前请求物业缴费插件时请求参数 communityRoomId
        /// </summary>
        [XmlElement("community_room_id")]
        public string CommunityRoomId { get; set; }

        /// <summary>
        /// 待缴账单通知用户 Uid 对应的openUid (与alipayUid对应)
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 小区编号。对应三方生态小区同步接口请求参数的out_community_id。
        /// </summary>
        [XmlElement("out_community_id")]
        public string OutCommunityId { get; set; }
    }
}
