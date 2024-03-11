import logo from './BowlingLogo.png';

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} className="logo" alt="Bowling Logo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white text-center">{props.title}</h1>
      </div>
    </header>
  );
}

export default Header;
