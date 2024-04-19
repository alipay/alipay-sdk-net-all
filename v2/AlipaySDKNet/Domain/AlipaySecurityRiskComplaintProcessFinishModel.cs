using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipaySecurityRiskComplaintProcessFinishModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskComplaintProcessFinishModel : AopObject
    {
        /// <summary>
        /// 本次进行处理的投诉id列表(主表主键)
        /// </summary>
        [XmlArray("id_list")]
        [XmlArrayItem("number")]
        public List<long> IdList { get; set; }

        /// <summary>
        /// 投诉处理附加上传的图片文件列表，每个图片文件有url和key两个字段，通过调用文件上传接口获得url和key
        /// </summary>
        [XmlArray("img_file_list")]
        [XmlArrayItem("img_file")]
        public List<ImgFile> ImgFileList { get; set; }

        /// <summary>
        /// 商家处理投诉结果码
        /// </summary>
        [XmlElement("process_code")]
        public string ProcessCode { get; set; }

        /// <summary>
        /// 本次投诉处理的备注信息
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }
    }
}
