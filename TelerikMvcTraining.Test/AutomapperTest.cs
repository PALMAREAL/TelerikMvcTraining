using System;
using Xunit;
using FluentAssertions;
using TelerikMvcTraining.ViewModels;
using TelerikMvcTraining.Models;
using AutoMapper;
using TelerikMvcTraining.AutoMapper;
using TelerikMvcTraining.Dtos;

namespace TelerikMvcTraining.Test
{
    public class AutomapperTest : TestBase, IDisposable
    {
        /// <summary>
        /// Generic Mapping Entity to ViewModel.
        /// </summary>
        /// <param name="entityViewModel"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.VmToEntity), MemberType = typeof(AutomapperData))]
        public void MappingEntityViewModelSuccess(ViewModel<Entity> entityViewModel, Entity expected)
        {
            var result = Mapper.Map<Entity>(entityViewModel);
            result.Should().Equals(expected);
        }

        /// <summary>
        /// Mapping ProductViewModel to Product.
        /// </summary>
        /// <param name="productViewModel"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.ProductVmToEntity), MemberType = typeof(AutomapperData))]
        public void MappingProductSuccess(ProductViewModel productViewModel, Product expected)
        {
            var result = Mapper.Map<Product>(productViewModel);

            result.ProductID.Should().Be(expected.ProductID);

            result.ProductName.Should().Be(expected.ProductName);
        }

        /// <summary>
        /// Mapping CategoryViewModel to Cagegory. 
        /// </summary>
        /// <param name="categoryViewModel"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.CategoryVmToEntity), MemberType = typeof(AutomapperData))]
        public void MappingCategorySuccess(CategoryViewModel categoryViewModel, Category expected)
        {
            var result = Mapper.Map<Category>(categoryViewModel);

            result.CategoryID.Should().Be(expected.CategoryID);

            result.Description.Should().Be(expected.Description);
        }

        /// <summary>
        /// Mapping OrderViewModel to Order.
        /// </summary>
        /// <param name="orderViewModel"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.OrderViewModelToEntity), MemberType = typeof(AutomapperData))]
        public void MappingOrderSuccess(OrderViewModel orderViewModel, Order expected)
        {
            Order result = Mapper.Map<Order>(orderViewModel);

            result.OrderID.Should().Be(expected.OrderID);

            result.OrderDate.Should().Be(expected.OrderDate);

            result.CustomerID.Should().Be(expected.CustomerID);

            result.Category.Should().Be(expected.Category);

            result.Country.Should().Be(expected.Country);
        }

        /// <summary>
        /// Mapping Address entity to AddressDto.
        /// </summary>
        /// <param name="address"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.AddressToAddressDto), MemberType = typeof(AutomapperData))]
        public void MappingAddressDtoSuccess(Address address, AddressDto expected)
        {
            AddressDto result = Mapper.Map<AddressDto>(address);

            result.Ciudad.Should().Be(expected.Ciudad);

            result.Estado.Should().Be(expected.Estado);

            result.País.Should().Be(expected.País);
        }

        /// <summary>
        /// Mapping EmployeeDto to Employee.
        /// </summary>
        /// <param name="employeeDto"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.EmployeeDtoToEmployee), MemberType = typeof(AutomapperData))]
        public void MappingEmployeeSuccess(EmployeeDto employeeDto, Employee expected)
        {
            Employee result = Mapper.Map<Employee>(employeeDto);

            result.Name.Should().Be(expected.Name);

            result.Salary.Should().Be(expected.Salary);

            result.Department.Should().Be(expected.Department);

            result.Address.Should().Be(expected.Address);
        }

        /// <summary>
        /// Mapping EmployeViewModel to Employee.
        /// </summary>
        /// <param name="employeeVm"></param>
        /// <param name="expected"></param>
        [Theory]
        [MemberData(nameof(AutomapperData.EmployeeViewModelToEntity), MemberType = typeof(AutomapperData))]
        public void MappingEmployeeViewModelSuccess(EmployeeViewModel employeeVm, Employee expected)
        {
            Employee result = Mapper.Map<Employee>(employeeVm);

            result.EmployeeID.Should().Be(expected.EmployeeID);

            result.Address.Equals(expected.Address);

            result.Orders.Equals(expected.Orders);
        }

        public void Dispose()
        {
            
        }
    }
}
