using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotVendingmachineProfileQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotVendingmachineProfileQueryModel : AopObject
    {
        /// <summary>
        /// 设备唯一标识
        /// </summary>
        [XmlElement("biz_tid")]
        public string BizTid { get; set; }

        /// <summary>
        /// 商品code
        /// </summary>
        [XmlElement("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [XmlElement("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 请求的数据资源类型组合，多组数据用',' 分隔； 可选类型（多选）：RECOMMEND_GOODS || NEARBY_CROWD_DENSITY ||  CONSUMER_PROFILE ||  MARKETING_DATA ||
        /// </summary>
        [XmlElement("search_data_list")]
        public string SearchDataList { get; set; }

        /// <summary>
        /// 请求数据维度，设备维度，商品维度，商家维度等； 可选枚举： DEVICE || GOODS || MERCHANT
        /// </summary>
        [XmlElement("search_data_type")]
        public string SearchDataType { get; set; }

        /// <summary>
        /// 请求区间类型数据必传，如marketing_data_list；  拼接格式：起止时间_结束时间
        /// </summary>
        [XmlElement("time_interval")]
        public string TimeInterval { get; set; }
    }
}
