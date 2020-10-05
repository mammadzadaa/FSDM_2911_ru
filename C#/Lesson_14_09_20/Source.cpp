#include <iostream>


class Abstract
{
	public:
		virtual void foo() = 0
		{

		}		
};

class Inheritated : public Abstract
{
	public:
		void foo() override
		{
			Abstract::foo();
		}
};

template <typename T>
void foo(T val)
{

}

int main()
{
	//Abstract a;
	//Inheritated i;

	int* ptr = new int[10]{};
	ptr[0] = 1;
	ptr[1] = 54;
	ptr[5] = 3;
	std::cin.get();

	return 0;
}


