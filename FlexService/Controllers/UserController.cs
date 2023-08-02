using FlexCore.Models;
using FlexService.Models;
using Members.dll.Dtos;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Reflection;

namespace FlexService.Controllers
{
    [EnableCors("AllowAny")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly AppDbContext _db;

        /// <summary>
        /// 建構式將AppDbContext注入UserController
        /// </summary>
        /// <param name="db"></param>
        public UserController(AppDbContext db)
        {
            _db = db;
        }

        /// <summary>
        /// 註冊及會員登入
        /// </summary>
        /// <param name="regdto"></param>
        /// <returns></returns>
        [HttpPost("Register")]
        public async Task<RegisterDto> Register([FromBody] RegisterDto regdto)
        {
            if (_db.Members == null)
            {
                return null;
            }
            //第一次登入時先確認有沒有符合的會員資料
            RegisterDto registerDto = _db.Members.Where(m => m.Account == regdto.Account).Select(m => new RegisterDto
            {
                //Mobile = m.Mobile,
                Account = m.Account,
                EncryptedPassword = m.EncryptedPassword,
                Email = m.Email,
                //Birthday = m.Birthday,
                Name = m.Name
                //todo將密碼雜湊存入資料庫
            }).Single();

            return registerDto;
        }
        [HttpPost("Insert")]
        public async Task<string> Insert([FromBody] RegisterDto regdto)
        {
            FlexCore.Models.Members member = new FlexCore.Models.Members
            {
                Account = regdto.Account,
                EncryptedPassword = regdto.EncryptedPassword,
                Email = regdto.Email,
                Birthday = regdto.Birthday,
                Mobile = regdto.Mobile,
                Name= regdto.Name,
                fk_LevelId=1//一般會員
            };
            _db.Members.Add(member);
            await _db.SaveChangesAsync();
            return "新增會員成功";
        }

        [HttpPost("Verified")]
        public async Task<IActionResult> Verified([FromBody] RegisterDto regdto)
        {
            if (_db.Members == null)
            {
                return null;
            }
            RegisterDto registerDto = _db.Members.Where(m => m.Account == regdto.Account).Select(m => new RegisterDto
            {
                //Mobile = m.Mobile,
                //Email = m.Email,
                //Account = m.Account,
                //EncryptedPassword = m.EncryptedPassword,
                Name = m.Name
                //todo記得登入者show到畫面上


            }).Single();

            string userName = registerDto.Name;

            return Ok(new { userName });
        }

    }
}
