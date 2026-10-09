using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// DatadigitalFincloudGeneralsaasFaceCertifyVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class DatadigitalFincloudGeneralsaasFaceCertifyVerifyModel : AopObject
    {
        /// <summary>
        /// 本次申请操作的唯一标识，由H5人脸核身初始化接口调用后生成，后续的操作都需要用到
        /// </summary>
        [XmlElement("certify_id")]
        public string CertifyId { get; set; }
    }
}
