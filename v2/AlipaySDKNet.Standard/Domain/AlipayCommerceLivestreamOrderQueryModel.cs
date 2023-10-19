using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceLivestreamOrderQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceLivestreamOrderQueryModel : AopObject
    {
        /// <summary>
        /// 业务授权token，用户允许在该小程序上查询主播直播间订单数据。获取方法：小程序插件组件实例通过ref透出的auth方法获取
        /// </summary>
        [XmlElement("biz_token")]
        public string BizToken { get; set; }

        /// <summary>
        /// 查询订单范围的结束时间，以订单付款时间为准
        /// </summary>
        [XmlElement("end_time")]
        public string EndTime { get; set; }

        /// <summary>
        /// 默认值1
        /// </summary>
        [XmlElement("page")]
        public long Page { get; set; }

        /// <summary>
        /// 默认值，10
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 查询订单范围的开始时间，以订单付款时间为准
        /// </summary>
        [XmlElement("start_time")]
        public string StartTime { get; set; }
    }
}
