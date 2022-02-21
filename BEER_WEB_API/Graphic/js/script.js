
let [beers, setBeers] = useState ([])

 useEffect( () => {
    async function fetchData(async) {
    const res = await fetch("https://localhost:7275/api/Beer")
    const data = (await res.json())
    setCustomers(data)
}
    fetchData();
},[])

