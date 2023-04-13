namespace libMVP.Logic.Presenter
{
	using libMVP.Logic.Services;
	using libMVP.Model;
	using libMVP.Views.Interface;

	class categoryPresenter
	{
		private ICategory iCategory;

		private CategoryModel categoryModel = new CategoryModel();

		public categoryPresenter(ICategory iCategory)
		{
			this.iCategory = iCategory;
		}


		void conectBetweenModelInterface()
		{
			categoryModel.Id = iCategory.Id;
			categoryModel.CatName = iCategory.CatName;
		}


		public bool catinsert()
		{
			conectBetweenModelInterface();
			return categoryService.categoryinsert(categoryModel.Id, categoryModel.CatName);
		}
	}
}
