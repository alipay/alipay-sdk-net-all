using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenIotmbsIsvopendoorSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenIotmbsIsvopendoorSyncModel : AopObject
    {
        /// <summary>
        /// 外部传入的用户id
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 执行业务操作的项目id
        /// </summary>
        [XmlElement("project_id")]
        public string ProjectId { get; set; }

        /// <summary>
        /// 房号
        /// </summary>
        [XmlElement("room_num")]
        public string RoomNum { get; set; }

        /// <summary>
        /// 房门pad设备sn
        /// </summary>
        [XmlElement("sn")]
        public string Sn { get; set; }
    }
}
