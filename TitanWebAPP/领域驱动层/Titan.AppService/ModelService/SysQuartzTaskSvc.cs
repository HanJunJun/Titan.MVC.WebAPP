//------------------------------------------------------------------------------
//此代码由T4模板自动生成
//生成时间 2018-08-29 17:44:04
//对此文件的更改可能会导致不正确的行为，并且如果
//重新生成代码，这些更改将会丢失。
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Titan.Model;
using Titan.Model.DataModel;
using Titan.RepositoryCode;

namespace Titan.AppService.ModelService
{
    public class SysQuartzTaskSvc
    {
		private ModelRespositoryFactory<SysQuartzTask, Guid> _modeSvc;
        public SysQuartzTaskSvc(ModelRespositoryFactory<SysQuartzTask, Guid> modeSvc)
        {
            _modeSvc = modeSvc;
        }
		 /// <summary>
        /// 添加对象
        /// </summary>
        /// <returns></returns>
        public void AddModel(SysQuartzTask entity)
        {
             _modeSvc.Add(entity);
        }

		/// <summary>
        /// 修改对象
        /// </summary>
        /// <returns></returns>
        public void UpdateModel(SysQuartzTask entity)
        {
           _modeSvc.Save(entity);
        }

		/// <summary>
        /// 删除对象
        /// </summary>
        /// <returns></returns>
        public void DeleteModel(SysQuartzTask entity)
        {
              _modeSvc.Remove(entity);
        }

		/// <summary>
        /// 根据主键查询对象
        /// </summary>
        /// <returns></returns>
        public SysQuartzTask FindModelById(Guid id)
        {
            SysQuartzTask tav = _modeSvc.FindById(id);
            return tav;
        }

		/// <summary>
        /// 根据表达式查询集合
        /// </summary>
        /// <returns></returns>
        public List<SysQuartzTask> FindModelByValue(Expression<Func<SysQuartzTask, bool>> predicate)
        {       
            List<SysQuartzTask> tavList = _modeSvc.GetDatas(predicate).ToList();
            return tavList;
        }


		/// <summary>
        /// 根据根据条件查询并分页
        /// </summary>
        /// <param name="pageIndex">页面索引</param>
        /// <param name="pageSize">页面大小</param>
        /// <param name="rowCount">数据总数</param>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按string排序</param>
        /// <param name="orderby2">条件2：按string排序</param>
        /// <param name="isAsc">是否升序</param>
        public List<SysQuartzTask> GetModelList(int pageIndex,int pageSize,out int rowCount, Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, string>> orderby1,Expression<Func<SysQuartzTask, string>> orderby2,bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindPagedList(pageIndex, pageSize, out rowCount, selector, orderby1,orderby2, isAsc).ToList();
            return tavList;
        }

        /// <summary>
        /// 根据根据条件查询并分页
        /// </summary>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按string排序</param>
        /// <param name="orderby2">条件2：按string排序</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public List<SysQuartzTask> GetModelList(Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, string>> orderby1,Expression<Func<SysQuartzTask, string>> orderby2, bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindList(selector, orderby1,orderby2, isAsc).ToList();
            return tavList;
        }


	    /// <summary>
        /// 根据根据条件查询并分页
        /// </summary>
        /// <param name="pageIndex">页面索引</param>
        /// <param name="pageSize">页面大小</param>
        /// <param name="rowCount">数据总数</param>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按DateTime排序</param>
        /// <param name="orderby2">条件2：按DateTime排序</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public List<SysQuartzTask> GetModelListT(int pageIndex,int pageSize,out int rowCount, Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, DateTime>> orderby1,Expression<Func<SysQuartzTask, DateTime>> orderby2,bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindPagedList(pageIndex, pageSize, out rowCount, selector, orderby1,orderby2, isAsc).ToList();
            return tavList;
        }

		/// <summary>
        /// 根据根据条件查询并分页
        /// </summary>
        /// <param name="pageIndex">页面索引</param>
        /// <param name="pageSize">页面大小</param>
        /// <param name="rowCount">数据总数</param>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按DateTime排序</param>
        /// <param name="orderby2">条件2：按string排序</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public List<SysQuartzTask> GetModelListT(int pageIndex, int pageSize, out int rowCount, Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, DateTime>> orderby1, Expression<Func<SysQuartzTask, string>> orderby2, bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindPagedListOrderBy(pageIndex, pageSize, out rowCount, selector, orderby1, orderby2, isAsc).ToList();
            return tavList;
        }

		/// <summary>
        /// 根据根据条件查询
        /// </summary>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按DateTime排序</param>
        /// <param name="orderby2">条件2：按DateTime排序</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public List<SysQuartzTask> GetModelListT(Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, DateTime>> orderby1,Expression<Func<SysQuartzTask, DateTime>> orderby2, bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindList(selector, orderby1,orderby2, isAsc).ToList();
            return tavList;
        }



		/// <summary>
        /// 根据根据条件查询(多组合查询)
        /// </summary>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按int排序</param>
        /// <param name="orderby2">条件2：按DateTime排序</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public List<SysQuartzTask> GetModelListOrderBy(Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, int>> orderby1, Expression<Func<SysQuartzTask, DateTime>> orderby2, bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindListOrderBy(selector, orderby1, orderby2, isAsc).ToList();
            return tavList;
        }


		/// <summary>
        /// 根据根据条件查询(多组合查询)
        /// </summary>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="orderby1">条件1：按DateTime排序</param>
        /// <param name="orderby2">条件2：按string排序</param>
        /// <param name="isAsc">是否升序</param>
        /// <returns></returns>
        public List<SysQuartzTask> GetModelListOrderBy(Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, DateTime>> orderby1, Expression<Func<SysQuartzTask, string>> orderby2, bool isAsc)
        {
            List<SysQuartzTask> tavList = _modeSvc.FindListOrderBy(selector, orderby1, orderby2, isAsc).ToList();
            return tavList;
        }


		/// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="selector">查询条件lambda</param>
        /// <returns></returns>
        public int DeleteList(Expression<Func<SysQuartzTask, bool>> selector)
        {
            int t= _modeSvc.DeleteList(selector);
            return t;
        }


        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="selector">查询条件lambda</param>
        /// <param name="updateselector">更新对象</param>
        /// <returns></returns>
        public int UpdateList(Expression<Func<SysQuartzTask, bool>> selector, Expression<Func<SysQuartzTask, SysQuartzTask>> updateselector)
        {
            int t = _modeSvc.UpdateList(selector, updateselector);
            return t;
        }
    }
}
  