using System;
using System.Collections.Generic;
using System.Text;
using BigProject.Adds;
using BigProject.Services;
using BigProject.Validator;
using BigProject.Save;
using BigProject.Events;


namespace BigProject
{
    public class Container
    {
        private ISTC _showinf;
        private ILTD _logtodata;
        private AddIterface<Person> _person;
        private AddIterface<Payinf> _payinf;
        private IValidator<Person> _userValidate;
        private IValidator<Payinf> _payValidate;
        private InfoAdditorForPay _iafp;
        private InfoAdditorForUser _iafu;
        private RepositoryCRUD<Payinf> _savep;
        private RepositoryCRUD<Person> _saveu;

        public RepositoryCRUD<Payinf> Savep
        {
            get
            {
                if (_savep == null)
                {
                    var instance = new SavePay();
                    instance.News += Showinf.Message;
                    instance.Newl += Logtodata.LogData;
                    _savep = instance;
                }

                return _savep;
            }
        }
        public RepositoryCRUD<Person> Saveu
        {
            get
            {
                if (_saveu == null)
                {
                    var instance = new SaveUser();
                    instance.News += Showinf.Message;
                    instance.Newl += Logtodata.LogData;
                    _saveu = instance;
                }

                return _saveu;
            }
        }
        public ISTC Showinf
        {
            get
            {
                if (_showinf == null)
                {
                    _showinf = new ShowerToConsole();
                }
                return _showinf;
            }
        }
        public ILTD Logtodata
        {
            get
            {
                if (_logtodata == null)
                {
                    _logtodata = new LogToData();
                }
                return _logtodata;
            }
        }
        public AddIterface<Person> UserReader
        {
            get
            {
                if (_person == null)
                {
                    var instance = new ProPers();
                    instance.Newl += Logtodata.LogData;
                    _person = instance;
                }

                return _person;
            }
        }
        public AddIterface<Payinf> PayReader
        {         
            get
            {
                if (_payinf== null)
                {
                    var instance = new AddPay();
                    instance.Newl += Logtodata.LogData;
                    _payinf = instance;
                }

                return _payinf;
            }
        }
        public InfoAdditorForPay Iafp
        {
            get
            {
                if(_iafp == null)
                {
                    var instance = new InfoAdditorForPay(PayValidate, Savep);
                    instance.News += Showinf.Message;
                    instance.Newl += Logtodata.LogData;
                    _iafp = instance;
                }

                return _iafp;
            }
        }
        public IValidator<Payinf> PayValidate
        {
            get
            {
                if (_payValidate == null)
                {
                    var instance = new PayValidator();
                    instance.News += Showinf.Message;
                    _payValidate = instance;
                }

                return _payValidate;
            }
        }
        public InfoAdditorForUser Iafu
        {
            get
            {
                if (_iafu == null)
                {
                    var instance = new InfoAdditorForUser(UserValidate, Saveu);
                    instance.News += Showinf.Message;
                    instance.Newl += Logtodata.LogData;
                    _iafu = instance;
                }

                return _iafu;
            }
        }
        public IValidator<Person> UserValidate
        {
            get
            {
                if (_userValidate == null)
                {
                    var instance = new UserValidator();
                    instance.News += Showinf.Message;
                    _userValidate = instance;
                }

                return _userValidate;
            }
        }
    }
}
