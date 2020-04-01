using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// KbdishDictionary Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishDictionary : AopObject
    {
        /// <summary>
        /// 商家门店的操作小二,创建数据的人
        /// </summary>
        [XmlElement("create_user")]
        public string CreateUser { get; set; }

        /// <summary>
        /// 字典的数据id sync_type=update、stateChange和del时必填
        /// </summary>
        [XmlElement("dictionary_id")]
        public string DictionaryId { get; set; }

        /// <summary>
        /// 字典的扩展json，根据不同的biz_type，设置商家的自定义字典表key以及value。 如果字典类型为virtual_catetory和category一样的结构，并新增shopId和outDictionaryId，level只支持1 如果字典类型为catetory，key为cateSort（排序），level（层级，数字表示），parentCatetoryId（父类目id），cateType（dish或cook, 新增virtual表示虚拟类目定制），outDictionaryId（isv侧字典id）; 如果字典类型为spec，key为specSort（排序），capacity(容量，如400ml)，imageId(图片)，desc(描述)，viewTag(样式定制，杯型：杯型：ONE_ROW_THREE_COLUMN_WITH_PICTURE；温度：ONE_ROW_THREE_COLUMN；咖啡豆：PICTURE_TILE), upName(规格分类显示，如杯型)，outDictionaryId。 注意： 如果是字符串拼接的方式，转移符\要替换为\\\ 。
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得,这个是给isv点单用的必须要要明确的id
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 字典名称. 商家自定义的字符串
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// open 启动 stop 停用
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商户门店的操作小二,修改数据的人
        /// </summary>
        [XmlElement("update_user")]
        public string UpdateUser { get; set; }
    }
}
