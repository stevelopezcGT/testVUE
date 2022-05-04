<template>
    <div id="app">        
        <main>
            <div>
                <Home msg="Test Vue App" />
            </div>
        </main>
        
    </div>
</template>

<script>
    import Home from './components/Home.vue';
    

    export default {
        name: 'app',
        components: {
            Home
        }
    };
</script>

<style>

</style>

