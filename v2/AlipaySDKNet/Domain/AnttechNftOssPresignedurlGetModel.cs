using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnttechNftOssPresignedurlGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AnttechNftOssPresignedurlGetModel : AopObject
    {
        /// <summary>
        /// 上传文件数据的业务日期
        /// </summary>
        [XmlElement("business_date")]
        public string BusinessDate { get; set; }

        /// <summary>
        /// 上传文件的文件大小，用于校验上传文件不能超过限制值， 单位字节。
        /// </summary>
        [XmlElement("file_size")]
        public long FileSize { get; set; }

        /// <summary>
        /// 上传文件场景, 区分文件目录，以及为后续区分上传不同bucket作扩展
        /// </summary>
        [XmlElement("scenario_type")]
        public string ScenarioType { get; set; }
    }
}
