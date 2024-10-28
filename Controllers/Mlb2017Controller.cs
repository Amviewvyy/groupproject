using EFCoreWithAsp.netCore.Models;
using Microsoft.AspNetCore.Mvc;
using ProjectDatabase.Repositories;
using ProjectDatabase.ViewModels;
using System.Linq.Expressions;

namespace ProjectDatabase.Controllers
{
    public class Mlb2017Controller : Controller
    {
        private readonly IMlb2017Repository _mlb2017Repository;
        public Mlb2017Controller(IMlb2017Repository mlb2017Repository)
        {
            _mlb2017Repository = mlb2017Repository;
        }

        public async Task<IActionResult> Index(string searchString, string searchValue, string searchColumn, string sortOrder, int pageNumber, string currentFilter, string pageSize, string selectedMonth)
        {
            ViewData["CurrentSort"] = sortOrder;
            ViewData["SelectedMonth"] = selectedMonth;
            //Sorting
            ViewData["IdSortParam"] = sortOrder == "id_asc" ? "id_desc" : "id_asc";
            ViewData["DateSortParam"] = sortOrder == "date_asc" ? "date_desc" : "date_asc";
            ViewData["RotSortParam"] = sortOrder == "rot_asc" ? "rot_desc" : "rot_asc";
            ViewData["VHSortParam"] = sortOrder == "vh_asc" ? "vh_desc" : "vh_asc";
            ViewData["TeamSortParam"] = sortOrder == "team_asc" ? "team_desc" : "team_asc";
            ViewData["PitcherSortParam"] = sortOrder == "pitcher_asc" ? "pitcher_desc" : "pitcher_asc";
            ViewData["1stSortParam"] = sortOrder == "1st_asc" ? "1st_desc" : "1st_asc";
            ViewData["2ndSortParam"] = sortOrder == "2nd_asc" ? "2nd_desc" : "2nd_asc";
            ViewData["3rtSortParam"] = sortOrder == "3rt_asc" ? "3rt_desc" : "3rt_asc";
            ViewData["4thSortParam"] = sortOrder == "4th_asc" ? "4th_desc" : "4th_asc";
            ViewData["5thSortParam"] = sortOrder == "5th_asc" ? "5th_desc" : "5th_asc";
            ViewData["6thSortParam"] = sortOrder == "6th_asc" ? "6th_desc" : "6th_asc";
            ViewData["7thSortParam"] = sortOrder == "7th_asc" ? "7th_desc" : "7th_asc";
            ViewData["8thSortParam"] = sortOrder == "8th_asc" ? "8th_desc" : "8th_asc";
            ViewData["9thSortParam"] = sortOrder == "9th_asc" ? "9th_desc" : "9th_asc";
            ViewData["FinalSortParam"] = sortOrder == "final_asc" ? "final_desc" : "final_asc";
            ViewData["OpenSortParam"] = sortOrder == "open_asc" ? "open_desc" : "open_asc";
            ViewData["CloseSortParam"] = sortOrder == "close_asc" ? "close_desc" : "close_asc";
            ViewData["RunSortParam"] = sortOrder == "run_asc" ? "run_desc" : "run_asc";
            ViewData["OpenOUSortParam"] = sortOrder == "openou_asc" ? "openou_desc" : "openou_asc";
            ViewData["CloseOUSortParam"] = sortOrder == "closeou_asc" ? "closeou_desc" : "closeou_asc";

            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;

            var mlbs2017 = _mlb2017Repository.GetAllAsync();


            //Filtering
            if (!string.IsNullOrEmpty(searchColumn) && !string.IsNullOrEmpty(searchValue))
            {
                var propertyInfo = typeof(Mlb2017ViewModel).GetProperty(searchColumn);

                if (propertyInfo == null)
                {
                    ModelState.AddModelError("searchColumn", $"Property '{searchColumn}' does not exist.");
                }
                else if (propertyInfo.PropertyType != typeof(string) && propertyInfo.PropertyType != typeof(object) && propertyInfo.PropertyType != typeof(int))
                {
                    ModelState.AddModelError("searchColumn", "The specified column must be of type string, object, or int.");
                }
                else
                {
                    var param = Expression.Parameter(typeof(Mlb2017ViewModel), "e");
                    var property = Expression.Property(param, propertyInfo);

                    // เช็คว่าค่าเป็น string หรือ int
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        var toStringMethod = typeof(object).GetMethod("ToString");
                        var containsMethod = typeof(string).GetMethod("Contains", new[] { typeof(string) });

                        var searchValueConstant = Expression.Constant(searchValue, typeof(string));
                        var toStringCall = Expression.Call(property, toStringMethod);
                        var containsCall = Expression.Call(toStringCall, containsMethod, searchValueConstant);

                        var lambda = Expression.Lambda<Func<Mlb2017ViewModel, bool>>(
                            Expression.AndAlso(
                                Expression.NotEqual(property, Expression.Constant(null)),
                                containsCall
                            ),
                            param
                        );

                        mlbs2017 = mlbs2017.Where(lambda);
                    }
                    else if (propertyInfo.PropertyType == typeof(int))
                    {
                        if (int.TryParse(searchValue, out int searchIntValue))
                        {
                            var searchIntValueConstant = Expression.Constant(searchIntValue, typeof(int));
                            var equalExpression = Expression.Equal(property, searchIntValueConstant);

                            var lambda = Expression.Lambda<Func<Mlb2017ViewModel, bool>>(equalExpression, param);
                            mlbs2017 = mlbs2017.Where(lambda);
                        }
                        else
                        {
                            ModelState.AddModelError("searchValue", "Invalid integer value.");
                        }
                    }
                }
            }

            // Filtering by selected month
            if (!string.IsNullOrEmpty(selectedMonth))
            {
                int monthStart = 0;
                int monthEnd = 0;
                switch (selectedMonth)
                {
                    case "January":
                        monthStart = 101;
                        monthEnd = 131;
                        break;
                    case "February":
                        monthStart = 201;
                        monthEnd = 229;
                        break;
                    case "March":
                        monthStart = 301;
                        monthEnd = 331;
                        break;
                    case "April":
                        monthStart = 401;
                        monthEnd = 431;
                        break;
                    case "May":
                        monthStart = 501;
                        monthEnd = 531;
                        break;
                    case "June":
                        monthStart = 601;
                        monthEnd = 631;
                        break;
                    case "July":
                        monthStart = 701;
                        monthEnd = 731;
                        break;
                    case "August":
                        monthStart = 801;
                        monthEnd = 831;
                        break;
                    case "September":
                        monthStart = 901;
                        monthEnd = 931;
                        break;
                    case "October":
                        monthStart = 1001;
                        monthEnd = 1031;
                        break;
                    case "November":
                        monthStart = 1101;
                        monthEnd = 1131;
                        break;
                    case "December":
                        monthStart = 1201;
                        monthEnd = 1231;
                        break;
                    default:
                        break;
                }

                mlbs2017 = mlbs2017.Where(e => e.Date >= monthStart && e.Date <= monthEnd);


                // Filter the records based on the selected month
            }
            switch (sortOrder)
            {
                case "id_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Id);
                    break;
                case "id_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Id);
                    break;
                case "date_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Date);
                    break;
                case "date_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Date);
                    break;
                case "rot_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Rot);
                    break;
                case "rot_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Rot);
                    break;
                case "vh_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.VH);
                    break;
                case "vh_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.VH);
                    break;
                case "team_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Team);
                    break;
                case "team_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Team);
                    break;
                case "pitcher_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Pitcher);
                    break;
                case "pitcher_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Pitcher);
                    break;
                case "1st_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._1st);
                    break;
                case "1st_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._1st);
                    break;
                case "2nd_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._2nd);
                    break;
                case "2nd_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._2nd);
                    break;
                case "3rt_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._3rd);
                    break;
                case "3rt_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._3rd);
                    break;
                case "4th_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._4th);
                    break;
                case "4th_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._4th);
                    break;
                case "5th_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._5th);
                    break;
                case "5th_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._5th);
                    break;
                case "6th_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._6th);
                    break;
                case "6th_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._6th);
                    break;
                case "7th_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._7th);
                    break;
                case "7th_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._7th);
                    break;
                case "8th_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._8th);
                    break;
                case "8th_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._8th);
                    break;
                case "9th_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e._9th);
                    break;
                case "9th_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e._9th);
                    break;
                case "final_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Final);
                    break;
                case "final_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Final);
                    break;
                case "open_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Open);
                    break;
                case "open_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Open);
                    break;
                case "close_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Close);
                    break;
                case "close_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Close);
                    break;
                case "run_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.Close);
                    break;
                case "run_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.Close);
                    break;
                case "openou_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.OpenOU);
                    break;
                case "openou_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.OpenOU);
                    break;
                case "closeou_asc":
                    mlbs2017 = mlbs2017.OrderBy(e => e.CloseOU);
                    break;
                case "closeou_desc":
                    mlbs2017 = mlbs2017.OrderByDescending(e => e.CloseOU);
                    break;
                default:
                    mlbs2017 = mlbs2017.OrderBy(e => e.Id); // Default sorting by ID
                    break;
            }
            // Search functionality
            if (!string.IsNullOrEmpty(searchString))
            {
                var searchStringLower = searchString.ToLower();

                // ตรวจสอบถ้า searchString เป็นตัวเลข
                bool isNumericSearch = int.TryParse(searchString, out int searchIntValue);

                mlbs2017 = mlbs2017.Where(e =>
                    (e.Pitcher != null && e.Pitcher.ToLower().Contains(searchStringLower)) ||
                    (e.Team != null && e.Team.ToLower().Contains(searchStringLower)) ||
                    (e.VH != null && e.VH.ToLower().Contains(searchStringLower)) ||
                    (isNumericSearch && e.Date == searchIntValue) ||
                    (isNumericSearch && e.Rot == searchIntValue) ||
                    (isNumericSearch && e._1st == searchIntValue) ||
                    (isNumericSearch && e._2nd == searchIntValue) ||
                    (isNumericSearch && e._3rd == searchIntValue) ||
                    (isNumericSearch && e._4th == searchIntValue) ||
                    (isNumericSearch && e._5th == searchIntValue) ||
                    (isNumericSearch && e._6th == searchIntValue) ||
                    (isNumericSearch && e._7th == searchIntValue) ||
                    (isNumericSearch && e._8th == searchIntValue) ||
                    (isNumericSearch && e._9th == searchIntValue) ||
                    (isNumericSearch && e.Final == searchIntValue) ||
                    (isNumericSearch && e.Open == searchIntValue) ||
                    (isNumericSearch && e.Close == searchIntValue) ||
                    (isNumericSearch && e.Run_line == searchIntValue) ||
                    (isNumericSearch && e.OpenOU == searchIntValue) ||
                    (isNumericSearch && e.CloseOU == searchIntValue)
                );
            }

            // ตั้งค่า pageSize ถ้าไม่ถูกส่งมา

            if (string.IsNullOrEmpty(pageSize))
            {
                pageSize = "200"; // ค่าเริ่มต้นเป็น 5
            }
            ViewData["PageSize"] = pageSize;

            int selectedPageSize;

            // Ensure pageNumber is at least 1
            if (pageSize == "All")
            {
                selectedPageSize = mlbs2017.Count();
            }
            else
            {
                selectedPageSize = int.Parse(pageSize);
            }

            return View(await PaginatedList<Mlb2017ViewModel>.CreateAsync(mlbs2017.AsQueryable(), pageNumber, selectedPageSize));
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View(new Mlb2017ViewModel());
        }

        public async Task<IActionResult> Add(Mlb2017ViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            await _mlb2017Repository.AddAsync(model);
            return RedirectToAction();
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            //Delete the data from database
            await _mlb2017Repository.DeleteAsync(id);
            // Redirect to List all department page
            return RedirectToAction();
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Mlb2017ViewModel mlb2017)
        {

            if (!ModelState.IsValid)
            {
                return View(mlb2017); // Return to the form with validation errors
            }
            //Update the database with modified details
            await _mlb2017Repository.UpdateAsync(mlb2017);

            // Redirect to List all department page
            return RedirectToAction();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            //Fetch the employee details
            var mlb2017 = await _mlb2017Repository.GetByIdAsync(id);
            return View(mlb2017);
        }

        [HttpGet]
        public async Task<IActionResult> GroupByColumn(string groupColumn)
        {
            // ดึงข้อมูลทั้งหมดจาก repository
            var allRecords = await _mlb2017Repository.GetAllAsListAsync(); // ใช้เมธอดใหม่

            // ตรวจสอบให้แน่ใจว่า groupColumn เป็นชื่อคอลัมน์ที่ถูกต้อง
            if (string.IsNullOrEmpty(groupColumn) ||
                !typeof(Mlb2017ViewModel).GetProperties().Any(p => p.Name.Equals(groupColumn, StringComparison.OrdinalIgnoreCase)))
            {
                ModelState.AddModelError("groupColumn", "Invalid column name.");
                return View("YourView"); // แสดงฟอร์มอีกครั้งพร้อมกับข้อผิดพลาด
            }

            // ใช้ Reflection เพื่อจัดกลุ่มข้อมูลตามคอลัมน์ที่เลือก
            var groupedData = allRecords
                .GroupBy(record => record.GetType().GetProperty(groupColumn)?.GetValue(record, null))
                .Select(group => new
                {
                    Value = group.Key,
                    Count = group.Count()
                })
                .ToList();

            // สร้างโมเดลสำหรับส่งไปยัง view
            var viewModel = new GroupedViewModel // สมมติว่ามี ViewModel สำหรับแสดงผล

            {
                GroupedData = groupedData,
                GroupColumn = groupColumn // เพิ่มให้สามารถแสดงชื่อคอลัมน์ที่ถูกเลือกได้
            };

            // ส่งข้อมูลที่จัดกลุ่มไปยัง view
            return View("GroupedResults", viewModel);
        }
    }
}

