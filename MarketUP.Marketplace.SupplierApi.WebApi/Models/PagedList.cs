using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MarketUP.Marketplace.SupplierApi.WebApi.Models
{
    public abstract class PagedList
    {
        public int TotalItems { get; set; }

        public int Page { get; set; }

        public int TotalPages { get; set; }

        public int ItemsPage { get; set; }
    }

    public class PagedList<T> : PagedList
    {
        public List<T> Items { get; set; }

        public PagedList(int page, int pageSize, IOrderedQueryable<T> orderedQueryable)
        {
            if (page == 0)
                page = 1;

            this.TotalItems = orderedQueryable.Count();
            this.Page = page;
            this.ItemsPage = pageSize;

            if (this.TotalItems == 0 || this.ItemsPage == 0)
            {
                this.Page = 0;
                this.TotalPages = 0;
                this.Items = new List<T>();
            }
            else
            {
                this.TotalPages = ((this.TotalItems - 1) / this.ItemsPage) + 1;

                int skip = (page - 1) * pageSize;

                if (orderedQueryable.Count() > this.ItemsPage)
                    this.Items = orderedQueryable.Skip(skip).Take(pageSize).ToList();
                else
                    this.Items = orderedQueryable.ToList();
            }
        }

        public PagedList(int page, int pageSize, IOrderedEnumerable<T> orderedEnumerable)
        {
            if (page == 0)
                page = 1;

            this.TotalItems = orderedEnumerable.Count();
            this.Page = page;
            this.ItemsPage = pageSize;

            if (this.TotalItems == 0 || this.ItemsPage == 0)
            {
                this.Page = 0;
                this.TotalPages = 0;
                this.Items = new List<T>();
            }
            else
            {
                this.TotalPages = ((this.TotalItems - 1) / this.ItemsPage) + 1;

                int skip = (page - 1) * pageSize;

                if (orderedEnumerable.Count() > this.ItemsPage)
                    this.Items = orderedEnumerable.Skip(skip).Take(pageSize).ToList();
                else
                    this.Items = orderedEnumerable.ToList();
            }
        }

        public PagedList(int page, int pageSize, int totalItems, List<T> items)
        {
            if (page == 0)
                page = 1;

            this.TotalItems = totalItems;
            this.Page = page;
            this.ItemsPage = pageSize;

            if (this.TotalItems == 0 || this.ItemsPage == 0)
            {
                this.Page = 0;
                this.TotalPages = 0;
                this.Items = new List<T>();
            }
            else
            {
                this.TotalPages = ((this.TotalItems - 1) / this.ItemsPage) + 1;

                int skip = (page - 1) * pageSize;

                if (items.Count() > this.ItemsPage)
                    this.Items = items.Skip(skip).Take(pageSize).ToList();
                else
                    this.Items = items.ToList();
            }
        }

        public PagedList(int page, int pageSize, int totalItems, int totalPages, List<T> pagedItems)
        {
            this.Page = page;
            this.ItemsPage = pageSize;
            this.TotalItems = totalItems;
            this.TotalPages = totalPages;
            this.Items = pagedItems;
        }
    }
}