using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustActivityQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserDtbankcustActivityQueryModel : AopObject
    {
        /// <summary>
        /// 活动类型列表：  "FIRST_BIND_CARD_GIFT"--首绑有礼， "DISCOUNT"--立减活动， "VOUCHER"--渠道红包， "MORE_USE_CARD_GIFT"--多刷有礼
        /// </summary>
        [XmlArray("activity_type_list")]
        [XmlArrayItem("string")]
        public List<string> ActivityTypeList { get; set; }

        /// <summary>
        /// 卡类型 "CREDIT"--信用卡， "DEBIT"--借记卡
        /// </summary>
        [XmlArray("bank_card_type_list")]
        [XmlArrayItem("string")]
        public List<string> BankCardTypeList { get; set; }

        /// <summary>
        /// 银行机构号列表
        /// </summary>
        [XmlArray("bank_inst_id_list")]
        [XmlArrayItem("string")]
        public List<string> BankInstIdList { get; set; }

        /// <summary>
        /// 优惠可用场景对应biz_scene,格式：场景a:子场景1,子场景2;场景b:子场景3,子场景4； 只有主场景格式为：场景a:;场景b:
        /// </summary>
        [XmlElement("discount_use_scene_map_string")]
        public string DiscountUseSceneMapString { get; set; }

        /// <summary>
        /// 上页最后一个活动id，依赖这个进行分页，为空即第一页
        /// </summary>
        [XmlElement("last_activity_id")]
        public string LastActivityId { get; set; }

        /// <summary>
        /// 一次查询活动数量限制，不填默认为10，最大100，超过100按照100处理
        /// </summary>
        [XmlElement("limit")]
        public long Limit { get; set; }

        /// <summary>
        /// 来源，查询来源，初次接入，需要联系分配source
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 子来源，主要用来标识不同的业务块
        /// </summary>
        [XmlElement("sub_source")]
        public string SubSource { get; set; }

        /// <summary>
        /// 用户id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
