using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPartnerPrivilegeSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPartnerPrivilegeSyncModel : AopObject
    {
        /// <summary>
        /// 业务发生时间
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 是否使用悦管家服务。值可以为Y或N，只有当status=FINISHED时，此属性才需要必填，如果为空则默认按“未使用”处理。高铁接站场景属性
        /// </summary>
        [XmlElement("butler_use_flag")]
        public string ButlerUseFlag { get; set; }

        /// <summary>
        /// 是否使用礼宾车服务。值可以为Y或N，只有当status=FINISHED时，此属性才需要必填，如果为空则默认按“未使用”处理。高铁接站场景属性
        /// </summary>
        [XmlElement("car_use_flag")]
        public string CarUseFlag { get; set; }

        /// <summary>
        /// 所属城市，高铁接站场景需要填写
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 车厢号，高铁接站场景需要填写
        /// </summary>
        [XmlElement("compartment_number")]
        public string CompartmentNumber { get; set; }

        /// <summary>
        /// 当前用户在特权周期内已经享有次数
        /// </summary>
        [XmlElement("current_count")]
        public long CurrentCount { get; set; }

        /// <summary>
        /// 当前用户在商家侧的等级英文编码（如 golden 可表示黄金会员），如果商家没有等级体系，则使用默认等级码：member
        /// </summary>
        [XmlElement("grade")]
        public string Grade { get; set; }

        /// <summary>
        /// 当前等级的过期时间
        /// </summary>
        [XmlElement("grade_expired_time")]
        public string GradeExpiredTime { get; set; }

        /// <summary>
        /// 当前用户在特权记账周期内最大享有次数。例如，5元话费充值现金券，用户每月可领取并使用一次，那么，在记账周期（月）内用户最大享有次数为 1 次。
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部商家侧的机构ID，非必填，当pid无法区分商家时，合作商家需要传递此字段
        /// </summary>
        [XmlElement("out_partner_id")]
        public string OutPartnerId { get; set; }

        /// <summary>
        /// 用户手机号码，高铁接站场景需要填写
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 商家特权的ID，可唯一定位一个特权。可以是特权配置ID或数据库ID
        /// </summary>
        [XmlElement("privilege_id")]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// 注册渠道
        /// </summary>
        [XmlElement("register_channel")]
        public string RegisterChannel { get; set; }

        /// <summary>
        /// 由支付宝分配，具体值由支付宝定义。 D2D:高铁接站场景；INTERFLOW_PARTNER_MEMBER:互通联名会员场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 服务电话，高铁接站场景需要填写
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 站点信息，高铁接站场景需要填写
        /// </summary>
        [XmlElement("station")]
        public string Station { get; set; }

        /// <summary>
        /// 当前用户消费商家特权的状态：1.INIT（领取）；2.USED（已使用）；3.EXPIRED（已过期）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商家特权标题或名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 车次，高铁接站场景需要填写
        /// </summary>
        [XmlElement("train_number")]
        public string TrainNumber { get; set; }

        /// <summary>
        /// 特权记账周期：1.LIFE（终身）；2.YEAR（年）；3.SEASON（季度）；4.MONTH（月）；5.WEEK（周）；6.DAY（日）
        /// </summary>
        [XmlElement("trans_quantum")]
        public string TransQuantum { get; set; }

        /// <summary>
        /// 出行时间。格式： yyyy-MM-dd HH:mm:ss，高铁接站场景需要填写
        /// </summary>
        [XmlElement("travel_time")]
        public string TravelTime { get; set; }

        /// <summary>
        /// 用户姓名，高铁接站场景需要填写
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户支付金额。单位：元，只支持两位小数点的正数，如：88.88。如果用户无需额外支付金额，可不用传值。高铁接站场景属性
        /// </summary>
        [XmlElement("user_pay_amount")]
        public string UserPayAmount { get; set; }

        /// <summary>
        /// 供应商编码，非必填，当pid无法区分商家时，合作商家需要传递此字段
        /// </summary>
        [XmlElement("vendor")]
        public string Vendor { get; set; }
    }
}
