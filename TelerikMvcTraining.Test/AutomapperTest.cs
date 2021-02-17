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

        [Theory]
        [MemberData(nameof(AutomapperData.VmToEntity), MemberType = typeof(AutomapperData))]
        public void MappingEntityViewModelSuccess(ViewModel<Entity> entityViewModel, Entity expected)
        {
            var result = Mapper.Map<Entity>(entityViewModel);
            result.Should().Equals(expected);
        }

        [Theory]
        [MemberData(nameof(AutomapperData.ProductVmToEntity), MemberType = typeof(AutomapperData))]
        public void MappingProductSuccess(ProductViewModel productViewModel, Product expected)
        {
            var result = Mapper.Map<Product>(productViewModel);

            result.ProductID.Should().Be(expected.ProductID);

            result.ProductName.Should().Be(expected.ProductName);
        }

        [Theory]
        [MemberData(nameof(AutomapperData.CategoryVmToEntity), MemberType = typeof(AutomapperData))]
        public void MappingCategorySuccess(CategoryViewModel categoryViewModel, Category expected)
        {
            var result = Mapper.Map<Category>(categoryViewModel);

            result.CategoryID.Should().Be(expected.CategoryID);

            result.Description.Should().Be(expected.Description);
        }

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

        [Theory]
        [MemberData(nameof(AutomapperData.AddressToAddressDto), MemberType = typeof(AutomapperData))]
        public void MappingAddressDtoSuccess(Address address, AddressDto expected)
        {
            AddressDto result = Mapper.Map<AddressDto>(address);

            result.Ciudad.Should().Be(expected.Ciudad);

            result.Estado.Should().Be(expected.Estado);

            result.País.Should().Be(expected.País);
        }

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

        public void Dispose()
        {
            
        }
    }
}
