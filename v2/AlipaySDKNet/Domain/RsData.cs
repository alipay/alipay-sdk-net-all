using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// RsData Data Structure.
    /// </summary>
    [Serializable]
    public class RsData : AopObject
    {
        /// <summary>
        /// Nimitz 数据表
        /// </summary>
        [XmlElement("data")]
        public NimitzTable Data { get; set; }

        /// <summary>
        /// table 型数据集
        /// </summary>
        [XmlElement("rs_dataset")]
        public string RsDataset { get; set; }
    }
}
