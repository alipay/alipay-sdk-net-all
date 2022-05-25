using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenMiniTipsStatisticQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTipsStatisticQueryModel : AopObject
    {
        /// <summary>
        /// 收藏引导投放活动ID，供查询收藏引导活动配置接口调用 ，当以小程序维度查询数据（query_type为app）时delivery_id为空
        /// </summary>
        [XmlElement("delivery_id")]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 查询截止日期，精度为天
        /// </summary>
        [XmlElement("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 查询类型，表示以当前维度进行数据聚合。 app：小程序维度；activity：活动维度；
        /// </summary>
        [XmlElement("query_type")]
        public string QueryType { get; set; }

        /// <summary>
        /// 查询开始日期，精度为天
        /// </summary>
        [XmlElement("start_date")]
        public string StartDate { get; set; }
    }
}
