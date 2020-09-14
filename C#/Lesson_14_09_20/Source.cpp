

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
	Abstract a;
	Inheritated i;


	return 0;
}


