using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BookOrderDetailVO Data Structure.
    /// </summary>
    [Serializable]
    public class BookOrderDetailVO : AopObject
    {
        /// <summary>
        /// 预约信息
        /// </summary>
        [XmlArray("book_infos")]
        [XmlArrayItem("book_info_v_o")]
        public List<BookInfoVO> BookInfos { get; set; }

        /// <summary>
        /// 预约单
        /// </summary>
        [XmlElement("book_order")]
        public BookOrderVO BookOrder { get; set; }
    }
}
