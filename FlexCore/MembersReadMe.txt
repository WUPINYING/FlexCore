使用者相關功能：
UserController：
Register()：處理使用者註冊相關的功能。 帳號密碼->信箱登入(發送驗證碼)->Google、line/fB *第三方登入需要的欄位?*註冊驗證還沒寫完。
Login()：處理使用者登入相關的功能。 *已登入者無法留存在畫面上
Logout()：處理使用者登出相關的功能。


會員個人檔案及資訊：
ProfileController：
ViewProfile()：顯示會員個人檔案資訊。
EditProfile()：編輯會員個人檔案。
UpdateProfile()：更新會員個人檔案。


商品相關功能：
FavoritesController：
AddToFavorites()：將商品加入喜愛清單。
RemoveFromFavorites()：從喜愛清單移除商品。


優惠券相關功能：
CouponController：
ViewCoupons()：顯示會員可用的優惠券。
ClaimCoupon()：兌換優惠券。


會員積分相關功能：
PointsController：
ViewPoints()：顯示會員目前的積分。
EarnPoints()：處理獲得積分的相關功能。


瀏覽紀錄相關功能：
HistoryController：
ViewHistory()：顯示會員的瀏覽紀錄。