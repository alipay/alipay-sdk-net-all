using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ZmCardPictureInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ZmCardPictureInfo : AopObject
    {
        /// <summary>
        /// 图片名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户上传的证书编号或者图片编号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 图片存储id。可以通过开放接口【职得工作证图片上传】，即zhima.customer.jobworth.picture.upload获得
        /// </summary>
        [XmlElement("picture_id")]
        public string PictureId { get; set; }
    }
}
