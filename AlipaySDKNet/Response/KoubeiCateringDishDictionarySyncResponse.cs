using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// KoubeiCateringDishDictionarySyncResponse.
    /// </summary>
    public class KoubeiCateringDishDictionarySyncResponse : AopResponse
    {
        /// <summary>
        /// 字典的数据id
        /// </summary>
        [XmlElement("dictionary_id")]
        public string DictionaryId { get; set; }
    }
}
