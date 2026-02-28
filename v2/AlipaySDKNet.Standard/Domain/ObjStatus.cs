using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ObjStatus Data Structure.
    /// </summary>
    [Serializable]
    public class ObjStatus : AopObject
    {
        /// <summary>
        /// 业务对象标识
        /// </summary>
        [XmlElement("biz_object_no")]
        public string BizObjectNo { get; set; }

        /// <summary>
        /// 基本信息是否完整 true：是 false：否
        /// </summary>
        [XmlElement("completed_info")]
        public bool CompletedInfo { get; set; }

        /// <summary>
        /// 是否有地图 true: 是 false: 否
        /// </summary>
        [XmlElement("mapping")]
        public bool Mapping { get; set; }

        /// <summary>
        /// 是否分拣 true: 是 false: 否
        /// </summary>
        [XmlElement("sorting")]
        public bool Sorting { get; set; }
    }
}
