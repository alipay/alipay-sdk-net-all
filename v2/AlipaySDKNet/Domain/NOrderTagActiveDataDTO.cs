using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// NOrderTagActiveDataDTO Data Structure.
    /// </summary>
    [Serializable]
    public class NOrderTagActiveDataDTO : AopObject
    {
        /// <summary>
        /// 线圈外标唯一编号
        /// </summary>
        [XmlElement("coil_no")]
        public string CoilNo { get; set; }

        /// <summary>
        /// 线圈内标唯一id
        /// </summary>
        [XmlElement("tag_id")]
        public string TagId { get; set; }

        /// <summary>
        /// 唤端次数
        /// </summary>
        [XmlElement("touch_cnt")]
        public long TouchCnt { get; set; }

        /// <summary>
        /// 唤端用户数
        /// </summary>
        [XmlElement("touch_user_cnt")]
        public long TouchUserCnt { get; set; }
    }
}
