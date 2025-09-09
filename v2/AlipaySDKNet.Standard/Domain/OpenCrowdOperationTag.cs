using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// OpenCrowdOperationTag Data Structure.
    /// </summary>
    [Serializable]
    public class OpenCrowdOperationTag : AopObject
    {
        /// <summary>
        /// 标签所有必须的圈选项列表
        /// </summary>
        [XmlArray("operation_option_list")]
        [XmlArrayItem("open_crowd_operation_option")]
        public List<OpenCrowdOperationOption> OperationOptionList { get; set; }

        /// <summary>
        /// 棋盘人群圈选标签的唯一编码
        /// </summary>
        [XmlElement("tag_code")]
        public string TagCode { get; set; }

        /// <summary>
        /// 棋盘人群圈选标签的描述性信息
        /// </summary>
        [XmlElement("tag_desc")]
        public string TagDesc { get; set; }

        /// <summary>
        /// 棋盘人群圈选标签名称
        /// </summary>
        [XmlElement("tag_name")]
        public string TagName { get; set; }
    }
}
