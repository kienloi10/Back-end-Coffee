using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using apiModel;
using BackEndHighlandsCoffee.ViewModels;
using static BackEndHighlandsCoffee.ViewModels.ChiNhanhModel;
using BackEndHighlandsCoffee.Infrastructure;
using System.Web.Http.Cors;

namespace BackEndHighlandsCoffee.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ChiNhanhController : ApiController
    {
        
        
        private ApiDbContext db;


        private ErrorModel error;

        public ChiNhanhController()
        {
            db = new ApiDbContext();
            error = new ErrorModel();
        }


        /**
         * @api [Get] /ChiNhanh/ Get all ChiNhanh
         * @apiGroup ChiNhanh
         * @apiPermission none
         * 
         * 
         * @apiSuccess {int} Id Iid cua ChiNhanh
         * @apiSuccess {string} TenChiNhanh
         * @apiSuccess {DateTime} NgayThanhLap
         * @apiSuccess {string} DiaChi
         * 
         * @apiSuccessExample {json} Response:
         * {
         *      Id: 1,
         *      ChiNhanhId:1,
         *      TenChiNhanh: 'HighLand 01',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         * 
         * @apiError (400) {string[]} Errors Mang cac loi
         * 
         * @apiErrorExample: {json}
         * {
         *      "Errors": [
         *      
         *      ]
         *  }
         * 
         
        */
        [HttpGet]
        public IHttpActionResult GetAll()
        {
           
            var ds = this.db.ChiNhanhs.Select(x => new ChiNhanhModel()
            {
                Id = x.Id,
                ChiNhanhId=x.ChiNhanhId,
                TenChiNhanh = x.TenChiNhanh,
                NgayThanhLap = x.NgayThanhLap,
                DiaChi = x.DiaChi
            
            });
            
            return Ok(ds);
        }




        /**
         * @api [Get] /ChiNhanh/:id 
         * @apiGroup ChiNhanh
         * @apiPermission none
         *
         * @apiParam {int} Id 
         *
         * @apiParamExample {json} Request-Example:
         * {
         *      Id: 1,
         *      ChiNhanhId: 1,
         *      TenChiNhanh: 'HighLand 1',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         *
         * @apiSuccess {int} Id
         * @apiSuccess {string} TenChiNhanh  
         * @apiSuccess {DateTime} NgayThanhLap
         * @apiSuccess {string} DiaChi
         * 
         * @apiSuccessExample {json} Response:
         * {
         *      Id: 1,
         *      TenChiNhanh: 'HighLand 1',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         * 
         * 
         * @apiError (400) {string[]} Errors Mang cac loi
         * 
         * @apiErrorExample: {json}
         * {
         *      "Errors": [
         *          "Id không hợp lệ",
         *      ]
         * } 
         * 
         */
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            IHttpActionResult httpActionResult;

            var chiNhanh = db.ChiNhanhs.FirstOrDefault(x => x.Id == id);
            if(chiNhanh == null)
            {
                error.Add("Không tìm thấy chi nhánh");
                httpActionResult = new ErrorActionResult(Request, HttpStatusCode.BadRequest,error);
            } else
            {
                httpActionResult = Ok(new ChiNhanhModel(chiNhanh));
            }
            return httpActionResult;
        }



        /**
         * @api [Post] /ChiNhanh/ Tao mot CN moi
         * @apiGroup ChiNhanh
         * @apiPermission none
         * 
         * @apiParam {int} ChiNhanhId Ma cua CN moi 
         * @apiParam {string} TenChiNhanh Ten cua CN moi
         * @apiParam {string} DiaChi Dia chi cua CN moi
         * @apiParam {DateTime} NgayThanhLap NgayTL cua CN moi
         * 
         * @apiParamExample {json} Request-Example:
         * {
         *      ChiNhanhId: 1,
         *      TenChiNhanh: 'HighLand 1',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         * 
         * @apiSuccess {int} ChiNhanhId
         * @apiSuccess {string} TenChiNhanh
         * @apiSuccess {DateTime} NgayThanhLap 
         * @apiSuccess {string} DiaChi
         * 
         * @apiSuccessExample {json} Response:
         * {
         *      ChiNhanhId: 1,
         *      TenChiNhanh: 'HighLand 1',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         * 
         * 
         * @apiError (400) {string[]} Errors Mang cac loi
         * 
         * @apiErrorExample: {json}
         * {
         *      "Errors": [
         *          "Id la truong bat buoc",
         *          "TenChiNhanh la truong bat buoc",
         *          "DiaChi la truong bat buoc",
         *          "NgayThanhLap la truong bat buoc"
         *      ]
         * } 
         * 
         */
        [HttpPost]
        public IHttpActionResult Create(TaoChiNhanh cNModel)
        {
            IHttpActionResult httpActionResult;
            if (string.IsNullOrEmpty(cNModel.TenChiNhanh))
            {
                error.Add("Tên chi nhánh không được phép NULL");
            }

            if(error.Errors.Count == 0)
            {
                ChiNhanh chiNhanh = new ChiNhanh();
                chiNhanh.ChiNhanhId = cNModel.ChiNhanhId;
                chiNhanh.TenChiNhanh = cNModel.TenChiNhanh;
                chiNhanh.NgayThanhLap = cNModel.NgayThanhLap;
                chiNhanh.DiaChi = cNModel.DiaChi;
                chiNhanh = db.ChiNhanhs.Add(chiNhanh);

                db.SaveChanges();
                ChiNhanhModel chiNhanh_Model = new ChiNhanhModel(chiNhanh);
                httpActionResult = Ok(chiNhanh_Model);
            }
            else
            {
                httpActionResult = new ErrorActionResult(Request, HttpStatusCode.BadRequest, error);
            }
            return httpActionResult;
        }


        /**
         * @api [Put] /ChiNhanh/:id 
         * @apiGroup ChiNhanh
         * @apiPermission none
         *
         * @apiParam {int} Id Ma cua CN 
         *
         * @apiParamExample {json} Request-Example:
         * {
         *      Id: 1,
         *      ChiNhanhId:1,
         *      TenChiNhanh: 'HighLand 1',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         *
         * @apiSuccess {int} Id 
         * @apiSuccess {int} ChiNhanhId 
         * @apiSuccess {string} TenChiNhanh 
         * @apiSuccess {DateTime} NgayThanhLap
         * @apiSuccess {string} DiaChi
         * 
         * @apiSuccessExample {json} Response:
         * {
         *      ChiNhanhId: 1,
         *      TenChiNhanh: 'HighLand 1',
         *      NgayThanhLap: '1/1/2018',
         *      DiaChi: '1 Nguyen Du'
         * }
         * 
         * 
         * @apiError (400) {string[]} Errors Mang cac loi
         * 
         * @apiErrorExample: {json}
         * {
         *      "Errors": [
         *          "Id không hợp lệ",
         *      ]
         * } 
         * 
         */
        [HttpPut]
        public IHttpActionResult Update(CapNhatChiNhanh cNModel)
        {
            IHttpActionResult httpActionResult;
            ChiNhanh chiNhanh = db.ChiNhanhs.FirstOrDefault(x => x.Id == cNModel.Id);
            if(chiNhanh == null)
            {
                error.Add("Không tìm thấy chi nhánh");
                httpActionResult = new ErrorActionResult(Request, HttpStatusCode.BadRequest, error);
            }
            else
            {

                chiNhanh.TenChiNhanh = cNModel.TenChiNhanh ?? cNModel.TenChiNhanh;
                chiNhanh.DiaChi = cNModel.DiaChi ?? cNModel.DiaChi;
                db.Entry(chiNhanh).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                httpActionResult = Ok(new ChiNhanhModel(chiNhanh));


            }
            return httpActionResult;
        }
        /**
        * @api {DELETE} /class/Delete?Id=:Id Delete one class by Id
        * @apigroup ChiNhanh
        * @apiPermission none
        * 
        * @apiParam {int} Id Id
        * 
        * @apiExample Example usage: 
        * 
        * /class/Delete?Id=123
        * 
        * @apiSuccessExample {json} Response:
        * {
        *      Đã xóa chi nhánh abc
        * }
        * 
        * @apiError [400] {string[]} Errors Array of error
        * @apiErrorExample:{json}
        * {
        *      "Error":[
        *          Mã chi nhánh không tồn tạo!
        *      ]
        * }
        */
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            IHttpActionResult httpActionResult;
            ErrorModel error = new ErrorModel();
            var chiNhanh = db.ChiNhanhs.FirstOrDefault(x => x.Id == id);
            if (chiNhanh == null)
            {
                error.Add("Mã chi nhánh không tồn tạo!");
                httpActionResult = new ErrorActionResult(Request, System.Net.HttpStatusCode.BadRequest, error);
            }
            else
            {
                this.db.ChiNhanhs.Remove(chiNhanh);
                this.db.SaveChanges();
                httpActionResult = Ok("Đã xóa chi nhánh " + chiNhanh.TenChiNhanh);
            }
            return httpActionResult;
        }

    }
}
