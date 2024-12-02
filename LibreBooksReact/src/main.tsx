import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import App from './App.tsx'
import './main.tsx.css'
import { Provider } from 'react-redux'
import store from './stores/store.ts'

createRoot(document.getElementById('root')!).render(
	<StrictMode>
		<Provider store={store}>
			<App />
		</Provider>
	</StrictMode >,
)