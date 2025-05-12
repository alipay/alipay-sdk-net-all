using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// LogisticsWorkPlace Data Structure.
    /// </summary>
    [Serializable]
    public class LogisticsWorkPlace : AopObject
    {
        /// <summary>
        /// 对于铺设点的进一步描述，该值目前不会在作业小程序上展示，仅用作内部标识
        /// </summary>
        [XmlElement("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 铺设完成后，用户碰一下该线圈，实际需要跳转的地址
        /// </summary>
        [XmlElement("mini_app_redirect_url")]
        public string MiniAppRedirectUrl { get; set; }

        /// <summary>
        /// 铺设点地址。如果该值为空，铺设点地址会取值上层点位的位置信息
        /// </summary>
        [XmlElement("work_place_address")]
        public BusinessAddress WorkPlaceAddress { get; set; }

        /// <summary>
        /// 物流行业作业平台线圈作业时的最小铺设单位。 例如：蚂蚁A空间北门的柜组下有3个柜子需要铺设线圈。柜组ID=点位ID，柜子ID=铺设点ID
        /// </summary>
        [XmlElement("work_place_id")]
        public string WorkPlaceId { get; set; }

        /// <summary>
        /// 物流行业作业平台线圈作业时的最小铺设单位。 例如：蚂蚁A空间北门的柜组下有3个柜子需要铺设线圈。柜组ID=点位ID，柜子ID=铺设点ID
        /// </summary>
        [XmlElement("work_place_name")]
        public string WorkPlaceName { get; set; }
    }
}
