using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// FinancePurchaseInfo Data Structure.
    /// </summary>
    [Serializable]
    public class FinancePurchaseInfo : AopObject
    {
        /// <summary>
        /// 采购内容描述
        /// </summary>
        [XmlElement("content")]
        public string Content { get; set; }

        /// <summary>
        /// 文件信息列表
        /// </summary>
        [XmlArray("file_list")]
        [XmlArrayItem("finance_file_info")]
        public List<FinanceFileInfo> FileList { get; set; }
    }
}
