using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZhimaDataStateDataSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaDataStateDataSyncModel : AopObject
    {
        /// <summary>
        /// 同步的数据具体内容(json字符串)，开发前与技术对接，将会给出需要的字段模型
        /// </summary>
        [XmlElement("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 此状态需要与产品负责人沟通，每个产品维护了不同的状态机。(如约定产品，在电影场景下，需要淘票票商户在用户购票后同步购票信息，则此code=CONTRACT_STATE_WATCH_MOVIE_BUY)
        /// </summary>
        [XmlElement("biz_state_code")]
        public string BizStateCode { get; set; }

        /// <summary>
        /// 此类目为分配给商户在内容下的不同分类，（如电影，直播）
        /// </summary>
        [XmlElement("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 外部业务订单流水号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部主体唯一id。（如淘票票中的电影id）
        /// </summary>
        [XmlElement("out_principal_id")]
        public string OutPrincipalId { get; set; }

        /// <summary>
        /// 芝麻信用service_id,商户在入驻芝麻信用商户平台后，创建信用服务完成时会生成唯一的service_id。
        /// </summary>
        [XmlElement("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
