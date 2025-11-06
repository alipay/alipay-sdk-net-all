using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// ClaimAttachmentUrlVo Data Structure.
    /// </summary>
    [Serializable]
    public class ClaimAttachmentUrlVo : AopObject
    {
        /// <summary>
        /// 该参数是同学提交理赔时的病历信息，需要同步给供应商，用户理赔报案使用。
        /// </summary>
        [XmlArray("anamnesis")]
        [XmlArrayItem("string")]
        public List<string> Anamnesis { get; set; }

        /// <summary>
        /// 该参数是同学在提交理赔时上传的证件资料，需要同步给供应商报案使用。
        /// </summary>
        [XmlArray("ids")]
        [XmlArrayItem("string")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// 该参数是同学在提交理赔时，生成的理赔材料图片，需要同步给供应商进行报案使用。
        /// </summary>
        [XmlArray("invoice")]
        [XmlArrayItem("string")]
        public List<string> Invoice { get; set; }
    }
}
