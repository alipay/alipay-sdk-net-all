using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// CarfinPreMortgageInfo Data Structure.
    /// </summary>
    [Serializable]
    public class CarfinPreMortgageInfo : AopObject
    {
        /// <summary>
        /// 审核文件列表
        /// </summary>
        [XmlArray("approve_file_list")]
        [XmlArrayItem("carfin_pre_mortgage_file")]
        public List<CarfinPreMortgageFile> ApproveFileList { get; set; }

        /// <summary>
        /// 办理渠道 1 - 专网 2 - 公安网
        /// </summary>
        [XmlElement("channel")]
        public string Channel { get; set; }
    }
}
