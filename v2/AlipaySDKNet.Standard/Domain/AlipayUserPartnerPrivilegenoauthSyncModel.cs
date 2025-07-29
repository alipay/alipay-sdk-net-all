using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayUserPartnerPrivilegenoauthSyncModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserPartnerPrivilegenoauthSyncModel : AopObject
    {
        /// <summary>
        /// 业务发生时间，格式要求：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("biz_time")]
        public string BizTime { get; set; }

        /// <summary>
        /// 是否使用悦管家服务。值可以为Y或N，只有当status=FINISHED时，此属性才需要必填，如果为空则默认按“未使用”处理。
        /// </summary>
        [XmlElement("butler_use_flag")]
        public string ButlerUseFlag { get; set; }

        /// <summary>
        /// 是否使用礼宾车服务。值可以为Y或N，只有当status=FINISHED时，此属性才需要必填，如果为空则默认按“未使用”处理。
        /// </summary>
        [XmlElement("car_use_flag")]
        public string CarUseFlag { get; set; }

        /// <summary>
        /// 所属城市
        /// </summary>
        [XmlElement("city")]
        public string City { get; set; }

        /// <summary>
        /// 车厢号
        /// </summary>
        [XmlElement("compartment_number")]
        public string CompartmentNumber { get; set; }

        /// <summary>
        /// 当前用户在特权周期内已经享有次数。必须大于0
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
        /// 当前用户在特权周期内已经享有次数。必须大于0
        /// </summary>
        [XmlElement("max_count")]
        public long MaxCount { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务号。用作幂等控制，注意同步不同的状态时，外部业务号必须不同，否则会被幂等掉，无法正确同步数据。
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 外部商家侧的机构ID，非必填，当pid无法区分商家时，合作商家需要传递此字段
        /// </summary>
        [XmlElement("out_partner_id")]
        public string OutPartnerId { get; set; }

        /// <summary>
        /// 用户手机号码
        /// </summary>
        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 商家特权的ID，可唯一定位一个特权。可以是特权配置ID或数据库ID
        /// </summary>
        [XmlElement("privilege_id")]
        public string PrivilegeId { get; set; }

        /// <summary>
        /// 用户在商家的注册渠道编码
        /// </summary>
        [XmlElement("register_channel")]
        public string RegisterChannel { get; set; }

        /// <summary>
        /// 业务场景，由支付宝分配，具体值由支付宝定义： D2D：高铁接站场景，INTERFLOW_PARTNER_MEMBER：互通联名会员场景
        /// </summary>
        [XmlElement("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 服务电话
        /// </summary>
        [XmlElement("service_phone")]
        public string ServicePhone { get; set; }

        /// <summary>
        /// 站点信息
        /// </summary>
        [XmlElement("station")]
        public string Station { get; set; }

        /// <summary>
        /// 当前用户消费商家特权的状态：INIT：已领取，USED：已使用，EXPIRED：已过期，RESERVATION_SUCCESS：预约成功，IN_SERVICE：服务中，FINISHED：已完成，CHARGEABLE_CANCEL：有责取消，NON_CHARGEABLE_CANCEL：无责取消
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 商家特权标题或名称
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        [XmlElement("train_number")]
        public string TrainNumber { get; set; }

        /// <summary>
        /// 特权记账周期：LIFE：终身，YEAR：按年，SEASON：按季，MONTH：按月，WEEK：按周，DAY：按日，若不涉及则可统一填：LIFE
        /// </summary>
        [XmlElement("trans_quantum")]
        public string TransQuantum { get; set; }

        /// <summary>
        /// 出行时间。格式：yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("travel_time")]
        public string TravelTime { get; set; }

        /// <summary>
        /// 支付宝用户的userId。
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [XmlElement("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 用户支付金额。单位：元，只支持两位小数点的正数，如：88.88。如果用户无需额外支付金额，可不用传值。
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
