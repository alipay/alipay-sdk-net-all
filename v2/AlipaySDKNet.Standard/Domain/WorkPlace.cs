using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// WorkPlace Data Structure.
    /// </summary>
    [Serializable]
    public class WorkPlace : AopObject
    {
        /// <summary>
        /// 物流行业作业平台线圈作业时的最小铺设单位。 例如：蚂蚁A空间北门的柜组下有3个柜子需要铺设线圈。柜组ID=点位ID，柜子ID=铺设点ID
        /// </summary>
        [XmlElement("work_place_id")]
        public string WorkPlaceId { get; set; }
    }
}
