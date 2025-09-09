using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AxfOrderMemoInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AxfOrderMemoInfo : AopObject
    {
        /// <summary>
        /// 销售人员姓名
        /// </summary>
        [XmlElement("bd_name")]
        public string BdName { get; set; }

        /// <summary>
        /// 其他备注
        /// </summary>
        [XmlElement("other_memo")]
        public string OtherMemo { get; set; }
    }
}
