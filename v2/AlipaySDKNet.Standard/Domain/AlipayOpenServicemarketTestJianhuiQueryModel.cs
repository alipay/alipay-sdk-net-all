using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayOpenServicemarketTestJianhuiQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenServicemarketTestJianhuiQueryModel : AopObject
    {
        /// <summary>
        /// 测试用
        /// </summary>
        [XmlElement("jianhui_test")]
        public JhUserPageDetailTest JianhuiTest { get; set; }

        /// <summary>
        /// 页面显示数量
        /// </summary>
        [XmlElement("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 页码数
        /// </summary>
        [XmlElement("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        [XmlElement("total")]
        public long Total { get; set; }
    }
}
