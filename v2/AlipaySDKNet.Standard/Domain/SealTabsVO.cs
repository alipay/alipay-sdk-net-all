using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SealTabsVO Data Structure.
    /// </summary>
    [Serializable]
    public class SealTabsVO : AopObject
    {
        /// <summary>
        /// fileId关联标注哪一个文件
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }

        /// <summary>
        /// 是否全局关键字。默认false：第【pageNumber】页 第【kwIndex】个关键字；true：查询 全文本第【kwIndex】个【keyword】用印
        /// </summary>
        [XmlElement("global_key_word")]
        public bool GlobalKeyWord { get; set; }

        /// <summary>
        /// 签署位置关键字 关键字模式必传
        /// </summary>
        [XmlElement("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 签署关键字索引，默认第【pageNumber】页 第【kwIndex】个关键字
        /// </summary>
        [XmlElement("kw_index")]
        public long KwIndex { get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [XmlElement("page_number")]
        public long PageNumber { get; set; }

        /// <summary>
        /// 签署人位置识别类型：关键字签字||绝对坐标签字
        /// </summary>
        [XmlElement("seal_type")]
        public string SealType { get; set; }

        /// <summary>
        /// 签署组件类型
        /// </summary>
        [XmlElement("tab_type")]
        public string TabType { get; set; }

        /// <summary>
        /// textTabs初始话文本内容
        /// </summary>
        [XmlElement("text_tab_value")]
        public string TextTabValue { get; set; }

        /// <summary>
        /// 坐标用印x轴位置
        /// </summary>
        [XmlElement("x_position")]
        public long XPosition { get; set; }

        /// <summary>
        /// 坐标用印y轴位置
        /// </summary>
        [XmlElement("y_position")]
        public long YPosition { get; set; }
    }
}
