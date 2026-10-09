using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// StandardFacePutInfo Data Structure.
    /// </summary>
    [Serializable]
    public class StandardFacePutInfo : AopObject
    {
        /// <summary>
        /// 入库失败错误码
        /// </summary>
        [XmlElement("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 人脸用户ID
        /// </summary>
        [XmlElement("face_id")]
        public string FaceId { get; set; }

        /// <summary>
        /// 入库结果，SUCCESS： 入库成功 ; FAIL ：入库失败，可重试; ERROR：  入库失败，不可重试
        /// </summary>
        [XmlElement("result")]
        public string Result { get; set; }
    }
}
